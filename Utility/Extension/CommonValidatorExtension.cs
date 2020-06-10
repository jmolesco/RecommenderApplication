using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Utility.Extensions.Common;

namespace Utility.Extension
{
    public static class CommonValidatorExtension
    {
        #region String Validators
        public static IRuleBuilderOptions<T, string> NoSpecialCharacter<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new NoSpecialCharacterValidator());
        }

        public static IRuleBuilderOptions<T, string> SpecialAddressValidator<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new SpecialAddressValidator());
        }
        public static IRuleBuilderOptions<T, string> NoSpecialCharacterforFullName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new NoSpecialCharacterforFullName());
        }

        public static IRuleBuilderOptions<T, string> Numeric<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new IsNumericValidator());
        }
        public static IRuleBuilderOptions<T, string> Decimal<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new IsDecimalValidator());
        }

        public static IRuleBuilderOptions<T, string> Percentage<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new IsPercentValidator());
        }

        public static IRuleBuilderOptions<T, string> GreaterThan<T>(this IRuleBuilder<T, string> ruleBuilder, decimal minimumVal)
        {
            return ruleBuilder.SetValidator(new GreaterThanValidator(minimumVal));
        }

        public static IRuleBuilderOptions<T, string> LessThanEqualTo<T>(this IRuleBuilder<T, string> ruleBuilder, decimal maximumVal)
        {
            return ruleBuilder.SetValidator(new LessThanEqualTo(maximumVal));
        }

        public static IRuleBuilderOptions<T, string> LeadingAndTrailingSpace<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new LeadingTrailingSpaceValidator());
        }

        public static IRuleBuilderOptions<T, string> NumericalCharacterOnly<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new NumericalCharacterValidator());
        }
        public static IRuleBuilderOptions<T, string> IsPhoneNumber<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new IsPhoneValidator());
        }
        public static IRuleBuilderOptions<T, string> PasswordValidator<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new PasswordValidator());
        }
        /// <summary>
        /// Check for non Ascii Characters
        /// </summary>
        public static IRuleBuilderOptions<T, string> CharacterAsciiValidator<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new CharacterAsciiValidator());
        }
        /// <summary>
        /// Check for character length
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="min">Input minimum requirement</param>
        /// <param name="max">Input maximum requirement></param>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, string> MinMaxLengthValidator<T>(this IRuleBuilder<T, string> ruleBuilder, long min, long max)
        {
            return ruleBuilder.SetValidator(new LengthValidator(min, max));
        }

        /// <summary>
        /// Accepted Characters a-zA-Z 0-9  . , - # + ( ) /
        /// </summary>
        public static IRuleBuilderOptions<T, string> LimitedSpecialCharacterValidator<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new LimitedSpecialCharacterValidator());
        }
        #endregion

        #region File Validators
        public static IRuleBuilderOptions<T, IFormFile> MaxUploadSize<T>(this IRuleBuilder<T, IFormFile> ruleBuilder, long fileSize)
        {
            return ruleBuilder.SetValidator(new FileSizeValidator(fileSize));
        }
        public static IRuleBuilderOptions<T, IFormFile> MinUploadSize<T>(this IRuleBuilder<T, IFormFile> ruleBuilder, long fileSize)
        {
            return ruleBuilder.SetValidator(new FileSizeMinimumValidator(fileSize));
        }
        #endregion


    }

}
