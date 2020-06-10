using APP_ADMIN.DataModel.School.StrandCategory;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using Services.Admin.School.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.EnvironmentSettings;
using Utility.Extension;
using Utility.Helpers;
using Utility.Localization;
using Utility.Localization.Languages;

namespace APP_ADMIN.Validator.School.StrandCategory
{
    public class StrandInsertValidator : AbstractValidator<StrandCategoryInsertModel>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AppSettings _appSettings;
        private readonly ISchoolService schoolService;
        public StrandInsertValidator(
            IStringLocalizer<SharedResource> sharedLocalizer,
            IOptions<AppSettings> appSettings,
            ISchoolService _schoolService,
            IHttpContextAccessor httpContextAccessor,
            bool editMode = false
            )
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;
            _appSettings = appSettings.Value;
            schoolService = _schoolService;
            _httpContextAccessor = httpContextAccessor;


            RuleFor(reg => reg.StrandCode)
                      .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                          .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                              .MaximumLength(CharacterLengthHelper.FieldSize100).WithMessage(sharedLocalizer[ErrorMsgKeys.MaxCharacterLength])
                                           .LeadingAndTrailingSpace().WithMessage(sharedLocalizer[ErrorMsgKeys.IsInvalid])
                                                   .WithName(LabelMsgKeys.StrandCode);



            RuleFor(reg => reg.Description)
                      .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                          .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                              .MaximumLength(CharacterLengthHelper.FieldSize255).WithMessage(sharedLocalizer[ErrorMsgKeys.MaxCharacterLength])
                                           .LeadingAndTrailingSpace().WithMessage(sharedLocalizer[ErrorMsgKeys.IsInvalid])
                                                   .WithName(LabelMsgKeys.Description);

            RuleFor(reg => reg.TrackCategoryID)
                      .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                          .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                                .Must(IsExist).WithMessage(
                                        string.Format(sharedLocalizer[ErrorMsgKeys.DoesNotExist], LabelMsgKeys.TrackCategoryID)
                                        )
                                                   .WithName(LabelMsgKeys.TrackCategoryID);

            if (editMode == false)
            {
                RuleFor(reg => reg.StrandName)
                  .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                      .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                          .MaximumLength(CharacterLengthHelper.FieldSize100).WithMessage(sharedLocalizer[ErrorMsgKeys.MaxCharacterLength])
                                       .LeadingAndTrailingSpace().WithMessage(sharedLocalizer[ErrorMsgKeys.IsInvalid])
                                            .Must(ValidatExist).WithMessage(sharedLocalizer[ErrorMsgKeys.AlreadyExist])
                                               .WithName(LabelMsgKeys.StrandName);
            }
        }
        private bool ValidatExist(string strand)
        {
            return schoolService.IsStrandExists(strand);
        }

        private bool IsExist(int id)
        {
            var result = schoolService.GetTrackById(null, id);
            return !(result==null);
        }
    }

}