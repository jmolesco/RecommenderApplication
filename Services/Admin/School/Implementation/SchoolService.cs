using Infrastracture.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.School;
using Services.Admin.School.Services;
using Utility.Enum.Common;
using Utility.Enum.School;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Utility.Extension;
using Utility.Response;

namespace Services.Admin.School.Implementation
{
    public class SchoolService :ISchoolService
    {
        private readonly IBaseRepository<Domain.School.School> _schoolRepository;
        private readonly IBaseRepository<Domain.School.TrackCategory> _trackRepository;
        private readonly IBaseRepository<Domain.School.StrandCategory> _strandRepository;

        public SchoolService(IBaseRepository<Domain.School.School> schoolRepository,
            IBaseRepository<Domain.School.TrackCategory> trackRepository,
            IBaseRepository<Domain.School.StrandCategory> strandRepository
            )
        {
            _schoolRepository = schoolRepository;
            _trackRepository = trackRepository;
            _strandRepository = strandRepository;
        }

        #region SCHOOL
        #endregion

        #region TRACK
        public void InsertTrack(TrackCategory model)
        {
            using (var transaction = _trackRepository.BeginTransaction())
            {
                try
                {
                    _trackRepository.Insert(model);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }

        public void UpdateTrack(TrackCategory model, bool isDelete = false)
        {
            using (var transaction = _trackRepository.BeginTransaction())
            {
                try
                {
                    var result = _trackRepository.Get(obj => obj.TrackCategoryID == model.TrackCategoryID);
                    if(isDelete == false)
                    {
                        result.TrackCode = model.TrackCode;
                        result.TrackName = model.TrackName;
                        result.Status = model.Status;
                        result.Description = model.Description;
                    }
                    else
                    {
                        result.TrackCategoryID = model.TrackCategoryID;
                        result.Status = model.Status;
                    }
                    _trackRepository.Update(result);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }
        public object GetAllTrack(int CurrentPage, string Keyword, EnumOrderBy? OrderByCriteria, EnumOrderType? OrderTypeCriteria,
            EnumFilterBy? FilterBy, EnumSchoolSearchBy? SearchBy, bool ShowAll,  int MaxRecordPerPage)
        {
            var records = _trackRepository.Queryable().AsNoTracking().
                Select(p => new {
                    p.TrackCategoryID,
                    p.TrackCode,
                    p.TrackName,
                    p.Description,
                    p.Status,
                    p.DateCreated,
                    p.DateModified
                });

            //Search
            if (Keyword.HasValue())
            {
                if (SearchBy.HasValue)
                {
                    if(SearchBy == EnumSchoolSearchBy.Name)
                    {
                        records = records.Where(p => p.TrackName.Contains(Keyword));
                    }
                    else if(SearchBy == EnumSchoolSearchBy.Code)
                    {
                        records = records.Where(p => p.TrackCode.Contains(Keyword));
                    }
                    else
                    {
                        records = records.Where(p => p.TrackName.Contains(Keyword) || p.TrackCode.Contains(Keyword) );
                    }
                }
                else
                {
                    records = records.Where(p => p.TrackName.Contains(Keyword) || p.TrackCode.Contains(Keyword));
                }
            }


            //Filter
            if (FilterBy.HasValue)
            {
                if (FilterBy == EnumFilterBy.ACTIVE)
                {
                    records = records.Where(x => x.Status == Convert.ToBoolean(EnumFilterBy.ACTIVE));
                }
                else if (FilterBy == EnumFilterBy.INACTIVE)
                {
                    records = records.Where(x => x.Status == Convert.ToBoolean(EnumFilterBy.INACTIVE));
                }               
            }

            //Sorting
            if (OrderByCriteria.HasValue)
            {
                if (OrderByCriteria == EnumOrderBy.Name)
                {
                    if (OrderTypeCriteria == EnumOrderType.DESCENDING)
                    {
                        records = records.OrderByDescending(p => p.TrackName);
                    }
                    else
                    {
                        records = records.OrderBy(p => p.TrackName);
                    }
                }
                else if (OrderByCriteria == EnumOrderBy.Code)
                {
                    if (OrderTypeCriteria == EnumOrderType.DESCENDING)
                    {
                        records = records.OrderByDescending(p => p.TrackCode);
                    }
                    else
                    {
                        records = records.OrderBy(p => p.TrackCode);
                    }
                }
                else if (OrderByCriteria == EnumOrderBy.DateCreated)
                {
                    if (OrderTypeCriteria == EnumOrderType.DESCENDING)
                    {
                        records = records.OrderByDescending(p => p.DateCreated);
                    }
                    else
                    {
                        records = records.OrderBy(p => p.DateCreated);
                    }
                }
            }


            GetAllResponse response = null;

            if (ShowAll == false)
            {
                response = new GetAllResponse(records.Count(), CurrentPage, MaxRecordPerPage);
                records = records.Skip((CurrentPage - 1) * MaxRecordPerPage).Take(MaxRecordPerPage);
            }
            else
            {
                response = new GetAllResponse(records.Count());
            }
            response.List.AddRange(records);
            return response;

        }
        public TrackCategory GetTrackById(String trackName = null, int? trackCode = null )
        {
            var result = _trackRepository.Get(obj => obj.TrackName.Equals(trackName));
            if(result == null)
            {
                result = _trackRepository.Get(obj => obj.TrackCategoryID == trackCode);
            }
            return result;
        }

        public bool IsTrackExists(string TrackName)
        {
            var result = _trackRepository.Get(obj => obj.TrackName.Equals(TrackName));
            return result==null;
        }

        public bool IsTrackExists(string TrackName, int TrackID)
        {
            var result = _trackRepository.Get(obj => obj.TrackName.Equals(TrackName) && obj.TrackCategoryID !=TrackID);
            return result == null;
        }
        #endregion

        #region STRAND

        public void InsertStrand(StrandCategory model)
        {
            using (var transaction = _strandRepository.BeginTransaction())
            {
                try
                {
                    _strandRepository.Insert(model);
                    transaction.Commit();
                }
                catch(Exception err)
                {
                    transaction.Rollback();
                }
            }
        }

        public void UpdateStrand(StrandCategory model, bool isDelete = false)
        {
            using (var transaction = _strandRepository.BeginTransaction())
            {
                try
                {
                    var result = _strandRepository.Get(obj => obj.StrandCategoryID == model.StrandCategoryID);
                  
                    if (isDelete == false)
                    {
                        result.StrandCode = model.StrandCode;
                        result.StrandName = model.StrandName;
                        result.Status = model.Status; 
                        result.Description = model.Description;
                        result.TrackCategoryID = model.TrackCategoryID;
                    }
                    else
                    {
                        result.StrandCategoryID = model.StrandCategoryID;
                        result.Status = model.Status;
                    }
                    _strandRepository.Update(result);
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }
        public object GetAllStrand(int CurrentPage, string Keyword, EnumOrderBy? OrderByCriteria, EnumOrderType? OrderTypeCriteria,
            EnumFilterBy? FilterBy, EnumSchoolSearchBy? SearchBy, bool ShowAll, int MaxRecordPerPage)
        {
            var records = _strandRepository.Queryable().AsNoTracking().
                Include(x=>x.TrackCategory).
                Select(p => new {
                    p.StrandCategoryID,
                    p.StrandCode,
                    p.StrandName,
                    p.Description,
                    p.Status,
                    p.DateCreated,
                    p.DateModified,
                    p.TrackCategoryID,
                    p.TrackCategory.TrackName
                });

            //Search
            if (Keyword.HasValue())
            {
                if (SearchBy.HasValue)
                {
                    if (SearchBy == EnumSchoolSearchBy.Name)
                    {
                        records = records.Where(p => p.StrandName.Contains(Keyword));
                    }
                    else if (SearchBy == EnumSchoolSearchBy.Code)
                    {
                        records = records.Where(p => p.StrandCode.Contains(Keyword));
                    }
                    else
                    {
                        records = records.Where(p => p.StrandName.Contains(Keyword) || p.StrandCode.Contains(Keyword));
                    }
                }
                else
                {
                    records = records.Where(p => p.StrandName.Contains(Keyword) || p.StrandCode.Contains(Keyword));
                }
            }


            //Filter
            if (FilterBy.HasValue)
            {
                if (FilterBy == EnumFilterBy.ACTIVE)
                {
                    records = records.Where(x => x.Status == Convert.ToBoolean(EnumFilterBy.ACTIVE));
                }
                else if (FilterBy == EnumFilterBy.INACTIVE)
                {
                    records = records.Where(x => x.Status == Convert.ToBoolean(EnumFilterBy.INACTIVE));
                }
            }

            //Sorting
            if (OrderByCriteria.HasValue)
            {
                if (OrderByCriteria == EnumOrderBy.Name)
                {
                    if (OrderTypeCriteria == EnumOrderType.DESCENDING)
                    {
                        records = records.OrderByDescending(p => p.StrandName);
                    }
                    else
                    {
                        records = records.OrderBy(p => p.StrandName);
                    }
                }
                else if (OrderByCriteria == EnumOrderBy.Code)
                {
                    if (OrderTypeCriteria == EnumOrderType.DESCENDING)
                    {
                        records = records.OrderByDescending(p => p.StrandCode);
                    }
                    else
                    {
                        records = records.OrderBy(p => p.StrandCode);
                    }
                }
                else if (OrderByCriteria == EnumOrderBy.DateCreated)
                {
                    if (OrderTypeCriteria == EnumOrderType.DESCENDING)
                    {
                        records = records.OrderByDescending(p => p.DateCreated);
                    }
                    else
                    {
                        records = records.OrderBy(p => p.DateCreated);
                    }
                }
            }


            GetAllResponse response = null;

            if (ShowAll == false)
            {
                response = new GetAllResponse(records.Count(), CurrentPage, MaxRecordPerPage);
                records = records.Skip((CurrentPage - 1) * MaxRecordPerPage).Take(MaxRecordPerPage);
            }
            else
            {
                response = new GetAllResponse(records.Count());
            }
            response.List.AddRange(records);
            return response;

        }
        public object GetStrandById(String strandName = null, int? strandCode = null)
        {
            var result = _strandRepository.Queryable().AsNoTracking().
                            Include(x => x.TrackCategory).
                            Select(p => new {
                                p.StrandCategoryID,
                                p.StrandCode,
                                p.StrandName,
                                p.Description,
                                p.Status,
                                p.DateCreated,
                                p.DateModified,
                                p.TrackCategoryID,
                                p.TrackCategory.TrackName
                            }).Where(obj => obj.StrandName == strandName).FirstOrDefault();
            if (result == null)
            {
                result = _strandRepository.Queryable().AsNoTracking().
                            Include(x => x.TrackCategory).
                            Select(p => new {
                                p.StrandCategoryID,
                                p.StrandCode,
                                p.StrandName,
                                p.Description,
                                p.Status,
                                p.DateCreated,
                                p.DateModified,
                                p.TrackCategoryID,
                                p.TrackCategory.TrackName
                            }).Where(obj=>obj.StrandCategoryID == strandCode).FirstOrDefault();
            }
            return result;
        }

        public bool IsStrandExists(string strandName)
        {
            var result = _strandRepository.Get(obj => obj.StrandName.Equals(strandName));
            return result == null;
        }

        public bool IsStrandExists(string strandName, int strandID)
        {
            var result = _strandRepository.Get(obj => obj.StrandName.Equals(strandName) && obj.StrandCategoryID != strandID);
            return result == null;
        }
        #endregion
    }
}
