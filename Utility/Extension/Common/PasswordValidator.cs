using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Utility.Localization;

namespace Utility.Extensions.Common
{
    public class PasswordValidator : PropertyValidator
    {
        public PasswordValidator() : base(ErrorMsgKeys.IsInvalid) { }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            var regexItem = new Regex(@"((?=.*\w)(?=.*[a-z])(?=.*\d)(?=.*[\W]).{6,})");
            return regexItem.IsMatch(value);
        }
    }
}
