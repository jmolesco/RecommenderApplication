using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Utility.Localization;
using Utility.Localization.Languages;

namespace Utility.Extensions.Common
{
    public class IsNumericValidator : PropertyValidator
    {
        public IsNumericValidator() :  base(ErrorMsgKeys.IsInvalid)
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            if (int.TryParse(value, out int tryValue))
            {
                return true;
            }
            return false;
        }
    }

    public class IsDecimalValidator : PropertyValidator
    {
        public IsDecimalValidator() :  base(String.Empty)
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            if (decimal.TryParse(value, out decimal tryValue))
            {
                return true;
            }
            return false;
        }
    }

    public class IsPercentValidator : PropertyValidator
    {
        public IsPercentValidator() :  base(String.Empty)
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            if (value.EndsWith("%"))
            {
                value = value.Replace("%", string.Empty);
            }

            if (decimal.TryParse(value, out decimal tryValue))
            {
                return true;
            }
            return false;
        }
    }


    public class GreaterThanValidator : PropertyValidator
    {
        private readonly decimal _value = 0;
        public GreaterThanValidator(decimal value) :  base(String.Empty)
        {
            _value = value;
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;

            if (decimal.TryParse(value, out decimal tryValue))
            {
                if (tryValue > _value)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class LessThanEqualTo : PropertyValidator
    {
        private readonly decimal _value = 0;
        public LessThanEqualTo(decimal value) :  base(String.Empty)
        {
            _value = value;
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;

            if (decimal.TryParse(value, out decimal tryValue))
            {
                if (tryValue <= _value)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class NumericalCharacterValidator : PropertyValidator
    {
        public NumericalCharacterValidator() : base(String.Empty)
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            var regexItem = new Regex(@"^[0-9]*$");
            return regexItem.IsMatch(value);
        }
    }
    public class IsPhoneValidator : PropertyValidator
    {
        public IsPhoneValidator() : base(String.Empty)
        {

        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as string;
            var result = Regex.IsMatch(value, "^0+$");
            return result?false:true;
        }
    }

}
