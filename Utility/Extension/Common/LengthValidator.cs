using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using Utility.Localization;

namespace Utility.Extensions.Common
{
    public class LengthValidator : PropertyValidator
    {
        private readonly long _minLength = 0;
        private readonly long _maxLength = 0;

        public LengthValidator(long minLength, long maxLength) : base(ErrorMsgKeys.CharacterLength)
        {
            this._minLength = minLength;
            this._maxLength = maxLength;
        }
        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            return value.Length >= this._minLength && value.Length <= this._maxLength;
        }
    }
}
