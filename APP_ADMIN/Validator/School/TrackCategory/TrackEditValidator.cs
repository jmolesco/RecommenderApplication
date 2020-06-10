using APP_ADMIN.DataModel.TrackCategory.School;
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

namespace APP_ADMIN.Validator.School.TrackCategory
{
    public class TrackEditValidator : AbstractValidator<TrackCategoryUpdateModel>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AppSettings _appSettings;
        private readonly ISchoolService schoolService;
        public TrackEditValidator(
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

            var validator = new TrackInsertValidator(sharedLocalizer,
                       appSettings, schoolService, _httpContextAccessor, true
                       );

            Include(validator);

            RuleFor(reg => reg.TrackCategoryID)
              .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                  .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                                  .WithName(LabelMsgKeys.TrackCategoryID);

            RuleFor(reg => reg.TrackName)
                  .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                      .NotEmpty().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                          .MaximumLength(CharacterLengthHelper.FieldSize100).WithMessage(sharedLocalizer[ErrorMsgKeys.MaxCharacterLength])
                                .LeadingAndTrailingSpace().WithMessage(sharedLocalizer[ErrorMsgKeys.IsInvalid])
                                      .WithName(LabelMsgKeys.TrackName);

            RuleFor(reg => reg).Custom((model, context) =>
            {
                if(!(ValidatExist(model.TrackName, model.TrackCategoryID)))
                {
                    context.AddFailure(new ValidationFailure(
                                                        LabelMsgKeys.TrackName,
                                                        string.Format(
                                                                sharedLocalizer[ErrorMsgKeys.AlreadyExistFormatted],
                                                                LabelMsgKeys.TrackName
                                                            )
                                                        ));
                }
            });
        }
        private bool ValidatExist(string trackName, int trackId)
        {
            return schoolService.IsTrackExists(trackName, trackId);
        }

    }

}