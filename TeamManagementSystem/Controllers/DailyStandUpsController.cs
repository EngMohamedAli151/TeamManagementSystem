using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Team.Core.DTO;
using Team.Services.Interfaces;
using TeamDataBase.Model;

namespace TeamManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyStandUpsController : ControllerBase
    {
        private readonly IDailyStandUpServices _dailyStandUpServices;
        public DailyStandUpsController(IDailyStandUpServices dailyStandUpServices)
        {
            _dailyStandUpServices = dailyStandUpServices;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll() 
        { 
           var get= _dailyStandUpServices.GetAll();
            return Ok(get);
        }
        [HttpGet("GetById")]
        public IActionResult Get(int id)
        { 
            var get=_dailyStandUpServices.GetById(id);
            return Ok(get);
        }
        [HttpGet("GetByDate")]
        public IActionResult GetByDate(string date) 
        { 
            var getDate=_dailyStandUpServices.GetByDate(date);
            return Ok(getDate);
        }
        [HttpPost("AddDailyStandUp")]
        public IActionResult Add(DailyStandUpDTO dto) 
        {
            var date = new DailyStandUp()
            {
                Date =Convert.ToDateTime(dto.Date),
                Status = dto.Status,

            };
           var save= _dailyStandUpServices.Add(date);
            return Ok(save);
        
        }
    }
}
