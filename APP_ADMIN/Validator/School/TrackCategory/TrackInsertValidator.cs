using APP_ADMIN.DataModel.TrackCategory.School;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP_ADMIN.Validator.School.TrackCategory
{
    public class TrackInsertValidator : AbstractValidator<TrackCategoryInsertModel>
    {
        public TrackInsertValidator()
        {

        }
    }
}
