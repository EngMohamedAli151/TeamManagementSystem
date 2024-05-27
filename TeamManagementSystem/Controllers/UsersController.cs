using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Team.Core.DTO;
using Team.Services.Interfaces;
using TeamDataBase.Model;

namespace TeamManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    { private readonly IUserServices _userServices;
        public UsersController(IUserServices userServices)
        {
            _userServices= userServices;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll() 
        {
            var Get= _userServices.GetAll();
            return Ok(Get);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id) 
        { 
            var GetId= _userServices.GetById(id);
            return Ok(GetId);
        }
        [HttpPost("AddUser")]
        public IActionResult Add( UserDTO dto)
        {
            var user = new User()
            {
             Name = dto.Name,
             NickName=dto.NickName,
              Mail=dto.Mail,
              Password=dto.Password,
              Phone=dto.Phone,

            };
            var add=_userServices.Add(user);
            return Ok(add);
        }

    }
}
