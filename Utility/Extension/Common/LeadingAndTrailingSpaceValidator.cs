using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using Utility.Localization;

namespace Utility.Extensions.Common
{
    public class LeadingTrailingSpaceValidator : PropertyValidator
    {
        public LeadingTrailingSpaceValidator() : base(ErrorMsgKeys.IsInvalid)
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            //leading and trailing space validation
            var value = context.PropertyValue as string;
            if(value != null)
            {
                return !(value.StartsWith(" ") || value.EndsWith(" "));
            }
            return true;
        }
    }
}
