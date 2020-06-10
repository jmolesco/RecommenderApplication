using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Utility.Localization;
using Utility.Localization.Languages;

namespace Utility.Extensions.Common
{
    public class NoSpecialCharacterValidator : PropertyValidator
    {
        public NoSpecialCharacterValidator() : base(String.Empty)
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            var regexItem = new Regex(@"^[a-zA-Z0-9' .,-]*$");
            return regexItem.IsMatch(value);
        }
    }
    public class NoSpecialCharacterforFullName : PropertyValidator
    {
        public NoSpecialCharacterforFullName() : base(String.Empty)
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            var regexItem = new Regex(@"^[a-zA-Z 0-9\.\,\'\-\n]*$");
            return regexItem.IsMatch(value);
        }
    }

    /// <summary>
    /// Accepted Characters a-zA-Z 0-9  . , - # + ( ) /
    /// </summary>
    public class LimitedSpecialCharacterValidator : PropertyValidator
    {
        public LimitedSpecialCharacterValidator() : base(ErrorMsgKeys.AcceptedSpecialCharacter)
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            if (value != null)
            {
                var regexItem = new Regex(@"^[a-zA-Z 0-9\.\,\-\#\+\(\)\/]*$");
                return regexItem.IsMatch(value);
            }
            return true;
        }
    }

    /// <summary>
    /// Check for non Ascii Characters
    /// </summary>
    public class CharacterAsciiValidator : PropertyValidator
    {
        public CharacterAsciiValidator() : base(ErrorMsgKeys.IsInvalid) { }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            var regexAscii = new Regex(@"[^\u0000-\u007F]+");
            return !regexAscii.IsMatch(value);
        }
    }
    public class SpecialAddressValidator : PropertyValidator {
        public SpecialAddressValidator() : base(ErrorMsgKeys.IsInvalid) { }
        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            var regexItem = new Regex(@"^[a-zA-Z0-9' .-]*$");
            return regexItem.IsMatch(value);
        }
    }

  
}
