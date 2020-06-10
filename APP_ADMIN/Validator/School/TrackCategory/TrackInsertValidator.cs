using APP_ADMIN.DataModel.TrackCategory.School;
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

namespace APP_ADMIN.Validator.School.TrackCategory
{
    public class TrackInsertValidator : AbstractValidator<TrackCategoryInsertModel>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AppSettings _appSettings;
        private readonly ISchoolService schoolService;
        public TrackInsertValidator(
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


            RuleFor(reg => reg.TrackCode)
                      .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                          .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                              .MaximumLength(CharacterLengthHelper.FieldSize100).WithMessage(sharedLocalizer[ErrorMsgKeys.MaxCharacterLength])
                                           .LeadingAndTrailingSpace().WithMessage(sharedLocalizer[ErrorMsgKeys.IsInvalid])
                                                   .WithName(LabelMsgKeys.TrackCode);



            RuleFor(reg => reg.Description)
                      .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                          .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                              .MaximumLength(CharacterLengthHelper.FieldSize100).WithMessage(sharedLocalizer[ErrorMsgKeys.MaxCharacterLength])
                                           .LeadingAndTrailingSpace().WithMessage(sharedLocalizer[ErrorMsgKeys.IsInvalid])
                                                   .WithName(LabelMsgKeys.Description);


            if (editMode == false)
            {
                RuleFor(reg => reg.TrackName)
                  .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                      .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                          .MaximumLength(CharacterLengthHelper.FieldSize100).WithMessage(sharedLocalizer[ErrorMsgKeys.MaxCharacterLength])
                                       .LeadingAndTrailingSpace().WithMessage(sharedLocalizer[ErrorMsgKeys.IsInvalid])
                                            .Must(ValidatExist).WithMessage(sharedLocalizer[ErrorMsgKeys.AlreadyExist])
                                               .WithName(LabelMsgKeys.TrackName);
            }
        }
        private bool ValidatExist(string trackName)
        {
            return schoolService.IsTrackExists(trackName);
        }

    }

}
