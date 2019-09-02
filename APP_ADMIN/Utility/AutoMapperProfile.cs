using APP_ADMIN.DataModel.School.StrandCategory;
using APP_ADMIN.DataModel.TrackCategory.School;
using AutoMapper;
using Domain.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP_ADMIN.Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TrackCategoryInsertModel, TrackCategory>();
            CreateMap<TrackCategoryUpdateModel, TrackCategory>();
            CreateMap<TrackCategoryModel, TrackCategory>();



            CreateMap<StrandCategoryInsertModel, StrandCategory>();
            CreateMap<StrandCategoryUpdateModel, StrandCategory>();
            CreateMap<StrandCategoryModel, StrandCategory>();
        }
    }
}
