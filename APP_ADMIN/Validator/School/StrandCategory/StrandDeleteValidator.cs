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
using Utility.Localization;
using Utility.Localization.Languages;

namespace APP_ADMIN.Validator.School.StrandCategory
{
    public class StrandDeleteValidator : AbstractValidator<StrandCategoryDeleteModel>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AppSettings _appSettings;
        private readonly ISchoolService schoolService;
        public StrandDeleteValidator(
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
                                  .WithName(LabelMsgKeys.TrackCategoryID);

            RuleFor(reg => reg.Status)
              .NotNull().WithMessage(sharedLocalizer[ErrorMsgKeys.Required])
                                  .WithName(LabelMsgKeys.Status);

        }
    }

}