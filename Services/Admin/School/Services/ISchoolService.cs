using Domain.School;
using System;
using System.Collections.Generic;
using System.Text;
using Utility.Enum.Common;
using Utility.Enum.School;

namespace Services.Admin.School.Services
{
    public interface ISchoolService
    {

        #region SCHOOL
        #endregion

        #region TRACK
        void InsertTrack(TrackCategory model);
        void UpdateTrack(TrackCategory model, bool isDelete = false);

        object GetAllTrack(int CurrentPage, string Keyword, EnumOrderBy? OrderByCriteria, EnumOrderType? OrderTypeCriteria,
           EnumFilterBy? FilterBy, EnumSchoolSearchBy? SearchBy, bool ShowAll, int MaxRecordPerPage);
        TrackCategory GetTrackById(String trackName = null, int? trackCode = null);


        bool IsTrackExists(String TrackName);
        
        #endregion

        #region STRAND
        void InsertStrand(StrandCategory model);
        void UpdateStrand(StrandCategory model, bool isDelete = false);

        object GetAllStrand(int CurrentPage, string Keyword, EnumOrderBy? OrderByCriteria, EnumOrderType? OrderTypeCriteria,
           EnumFilterBy? FilterBy, EnumSchoolSearchBy? SearchBy, bool ShowAll, int MaxRecordPerPage);

        StrandCategory GetStrandById(String strandName = null, int? strandCode = null);

        bool IsStrandExists(String TrackName);
        #endregion

    }
}
