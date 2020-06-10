using FluentValidation.Validators;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Utility.Localization;
using Utility.Localization.Languages;

namespace Utility.Extensions.Common
{
    public class FileSizeMinimumValidator : PropertyValidator
    {
        private readonly long _fileSize = 4101; // 4kb (denoted in bytes)

        public FileSizeMinimumValidator(long fileSize) :  base(ErrorMsgKeys.IsInvalid)
        {
            this._fileSize = fileSize;
        }
        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as IFormFile;
            return (_fileSize <= value.Length);
        }
    }
}
