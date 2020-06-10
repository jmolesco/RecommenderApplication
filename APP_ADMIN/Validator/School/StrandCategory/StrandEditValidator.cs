using APP_ADMIN.DataModel.School.StrandCategory;
using FluentValidation;
using FluentValidation.Results;
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
    public class StrandEditValidator : AbstractValidator<StrandCategoryUpdateModel>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AppSettings _appSettings;
        private readonly ISchoolService schoolService;
        public StrandEditValidator(
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


            RuleFor(reg => reg.StrandCategoryID)
                      .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                            .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                                 .WithName(LabelMsgKeys.StrandCategoryID);



            RuleFor(reg => reg.StrandName)
                  .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                      .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                          .MaximumLength(CharacterLengthHelper.FieldSize100).WithMessage(sharedLocalizer[ErrorMsgKeys.MaxCharacterLength])
                                .LeadingAndTrailingSpace().WithMessage(sharedLocalizer[ErrorMsgKeys.IsInvalid])
                                      .WithName(LabelMsgKeys.StrandName);

            RuleFor(reg => reg).Custom((model, context) =>
            {
                if (!(ValidateExist(model.StrandName, model.StrandCategoryID)))
                {
                    context.AddFailure(new ValidationFailure(
                                                        LabelMsgKeys.TrackName,
                                                        string.Format(
                                                                sharedLocalizer[ErrorMsgKeys.AlreadyExistFormatted],
                                                                LabelMsgKeys.StrandName
                                                            )
                                                        ));
                }
            });
        }
        private bool ValidateExist(string strand, int id)
        {
            return schoolService.IsStrandExists(strand, id);
        }

        private bool IsExist(int id)
        {
            var result = schoolService.GetStrandById(null, id);
            return !(result == null);
        }
    }

}