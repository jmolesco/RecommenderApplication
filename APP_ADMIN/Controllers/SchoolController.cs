using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP_ADMIN.DataModel.School;
using APP_ADMIN.DataModel.School.StrandCategory;
using APP_ADMIN.DataModel.School.TrackCategory;
using APP_ADMIN.DataModel.TrackCategory.School;
using AutoMapper;
using Domain.School;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Services.Admin.School.Services;
using Utility.EnvironmentSettings;
using Utility.Response;

namespace APP_ADMIN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _schoolService;
        private readonly AppSettings appSettings;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IMapper _mapper;
        public SchoolController(ISchoolService schoolService,
             IHostingEnvironment hostingEnvironment,
             IOptions<AppSettings> _appSettings,
             IHttpContextAccessor httpContext,
             IMapper mapper

           )
        {
            _schoolService = schoolService;
            _hostingEnvironment = hostingEnvironment;
            _httpContext = httpContext;
            _mapper = mapper;
            appSettings = _appSettings.Value;
        }

        #region TRACK
        [HttpPost("InsertTrack")]
        public IActionResult InsertTrack([FromBody] TrackCategoryInsertModel model)
        {
            var mappedTrack = _mapper.Map<TrackCategory>(model);
            _schoolService.InsertTrack(mappedTrack);
            return Ok(new
            {
                Status = StatusResponse.OK
            });
        }

        [HttpPut("UpdateTrack")]
        public IActionResult UpdateTrack([FromBody] TrackCategoryUpdateModel model)
        {
            var mappedTrack = _mapper.Map<TrackCategory>(model);
            _schoolService.UpdateTrack(mappedTrack);
            return Ok(new
            {
                Status = StatusResponse.OK
            });
        }

        [HttpPut("DeleteTrack")]
        public IActionResult DeleteTrack([FromBody] TrackCategoryDeleteModel model)
        {
            var mappedTrack = _mapper.Map<TrackCategory>(model);
            _schoolService.UpdateTrack(mappedTrack, true);
            return Ok(new
            {
                Status = StatusResponse.OK
            });
        }

        [HttpGet("GetTrack")]
        public IActionResult GetTrack([FromQuery] int id)
        {
            var result = _schoolService.GetTrackById(null,id);
            return Ok(result);
        }

        [HttpGet("GetAllTrack")]
        public IActionResult GetAllTrack([FromQuery] TrackCategoryModel model)
        {
            var result = _schoolService.GetAllTrack(model.CurrentPage, model.Keyword, model.OrderBy, model.OrderType, model.FilterBy, model.SearchBy, model.ShowAll, appSettings.MaxRecordCount);
            return Ok(result);
        }
        #endregion


        #region STRAND
        [HttpPost("InsertStrand")]
        public IActionResult InsertStrand([FromBody] StrandCategoryInsertModel model)
        {
            var mappedStrand = _mapper.Map<StrandCategory>(model);
            _schoolService.InsertStrand(mappedStrand);
            return Ok(new
            {
                Status = StatusResponse.OK
            });
        }

        [HttpPut("UpdateStrand")]
        public IActionResult UpdateStrand([FromBody] StrandCategoryUpdateModel model)
        {
            var mappedStrand = _mapper.Map<StrandCategory>(model);
            _schoolService.UpdateStrand(mappedStrand);
            return Ok(new
            {
                Status = StatusResponse.OK
            });
        }

        [HttpPut("DeleteStrand")]
        public IActionResult DeleteStrand([FromBody] StrandCategoryDeleteModel model)
        {
            var mappedStrand = _mapper.Map<StrandCategory>(model);
            _schoolService.UpdateStrand(mappedStrand, true);
            return Ok(new
            {
                Status = StatusResponse.OK
            });
        }

        [HttpGet("GetStrand")]
        public IActionResult GetStrand([FromQuery] int id)
        {
            var result = _schoolService.GetStrandById(null, id);
            return Ok(result);
        }

        [HttpGet("GetAllStrand")]
        public IActionResult GetAllStrand([FromQuery] StrandCategoryModel model)
        {
            var result = _schoolService.GetAllStrand(model.CurrentPage, model.Keyword, model.OrderBy, model.OrderType, model.FilterBy, model.SearchBy, model.ShowAll, appSettings.MaxRecordCount);
            return Ok(result);
        }

        #endregion


    }
}