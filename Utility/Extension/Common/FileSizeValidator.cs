using FluentValidation.Validators;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Utility.Localization;
using Utility.Localization.Languages;

namespace Utility.Extensions.Common
{
    public class FileSizeValidator : PropertyValidator
    {
        private readonly long _fileSize = 2000000; // 2MB (denoted in bytes)

        public FileSizeValidator(long fileSize) : base(ErrorMsgKeys.IsInvalid)
        {
            this._fileSize = fileSize;
        }
        protected override bool IsValid(PropertyValidatorContext context)
        {
            var value = context.PropertyValue as IFormFile;
            return (value.Length <= _fileSize);
        }
    }
}
