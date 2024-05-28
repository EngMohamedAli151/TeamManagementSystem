using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Team.Core.DTO;
using Team.Services.Interfaces;
using TeamDataBase.Model;

namespace TeamManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcountsController : ControllerBase
    {
        #region 
        //private readonly IUserServices _userServices;
        //    public AcountsController(IUserServices userServices)
        //    {
        //        _userServices= userServices;
        //    }
        //    [HttpGet("GetAll")]
        //    public IActionResult GetAll() 
        //    {
        //        var Get= _userServices.GetAll();
        //        return Ok(Get);
        //    }
        //    [HttpGet("GetById")]
        //    public IActionResult GetById(int id) 
        //    { 
        //        var GetId= _userServices.GetById(id);
        //        return Ok(GetId);
        //    }
        //    [HttpPost("AddUser")]
        //    public IActionResult Add( UserDTO dto)
        //    {
        //        var user = new User()
        //        {
        //         Name = dto.Name,
        //         NickName=dto.NickName,
        //          Mail=dto.Mail,
        //          Password=dto.Password,
        //          Phone=dto.Phone,

        //        };
        //        var add=_userServices.Add(user);
        //        return Ok(add);
        // }
        #endregion 
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAcountServices _acountService;

        public AcountsController(UserManager<IdentityUser> userManager, IAcountServices acountService)
        {
            _userManager = userManager;
            _acountService = acountService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO model)
        {
            var user = new IdentityUser { UserName = model.Username };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok(new { message = "User registered successfully" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);

            if (user == null || !await _userManager.CheckPasswordAsync(user, model.Password))
            {
                return Unauthorized("Invalid login attempt");
            }

            var token = _acountService.GenerateToken(user);

            return Ok(new { token });
        }
    }
}

