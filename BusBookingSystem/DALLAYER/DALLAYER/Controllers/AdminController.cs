using DALLAYER.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DALLAYER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly OnlineBusBookingDbContext _context;

        public AdminController(OnlineBusBookingDbContext context)
        {
            _context = context;
        }
        //create
        [HttpGet]
        public IActionResult Get()
        {
            var adminlogin = _context.Adminlogins.ToList();
            return Ok(adminlogin);
        }
        [HttpGet("{username}")]
        public IActionResult Get(String username)
        {
            var adminlogin = _context.Adminlogins.Find(username);
            if (adminlogin == null)
            {
                return NotFound();
            }
            return Ok(adminlogin);
        }
        [HttpPost]
        public IActionResult Post(Adminlogin adminlogin)
        {
            try
            {
                if (adminlogin.Username == "")
                {
                    return BadRequest("Invalid input. adminlogin object is null");
                }

                _context.Add(adminlogin);
                _context.SaveChanges();
                return Ok("Login created");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error:{ex.Message}");
            }
        }

        [HttpPut]
        public IActionResult Put(Adminlogin adminlogin)
        {
            var admin = _context.Adminlogins.Find(adminlogin.Username);
            if (admin == null)
            {
                return NotFound($"Logindetails not found with Username {adminlogin.Username}");
            }
            admin.Username = adminlogin.Username;
            admin.Pswrd = adminlogin.Pswrd;
            admin.Name = adminlogin.Name;
            _context.SaveChanges();
            return Ok("Logindetails Updated");
        }

        [HttpDelete]
        public IActionResult Delete(string UserName)
        {
            var adminlogin = _context.Adminlogins.Find(UserName);
            if (adminlogin == null)
            {
                return NotFound($"Adminlogin not found with adminusername {UserName}");
            }
            _context.Adminlogins.Remove(adminlogin);
            _context.SaveChanges();
            return Ok("Adminlogin deleted");
        }
    }
}

