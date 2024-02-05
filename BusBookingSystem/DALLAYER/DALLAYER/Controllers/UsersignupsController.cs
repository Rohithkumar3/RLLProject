using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DALLAYER.Models;

namespace DALLAYER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersignupsController : ControllerBase
    {
        private readonly OnlineBusBookingDbContext _context;

        public UsersignupsController(OnlineBusBookingDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usersign = _context.Usersignups.ToList();
            return Ok(usersign);
        }

        [HttpGet("{username}")]
        public IActionResult Get(String username)
        {
            var usersign = _context.Usersignups.Find(username);
            if (usersign == null)
            {
                return NotFound();
            }
            return Ok(usersign);
        }

        [HttpPost]
        public IActionResult Post(Usersignup usersignup)
        {
            try
            {
                if (usersignup.Username == "")
                {
                    return BadRequest("Invalid input. usersignup object is null");
                }

                _context.Add(usersignup);
                _context.SaveChanges();
                return Ok("User created");
            }

            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error:{ex.Message}");
            }
        }
        [HttpPut]
        public IActionResult Put(Usersignup usersignup)
        {
           
            var details = _context.Usersignups.Find(usersignup.Username);
            if (details == null)
            {
                return NotFound($"Logindetails not found with Username {usersignup.Username}");
            }
            details.Fullname = usersignup.Fullname;
            details.Dob = usersignup.Dob;
            details.Mobile = usersignup.Mobile;
            details.Email = usersignup.Email;
            details.Stat = usersignup.Stat;
            details.City = usersignup.City;
            details.Pincode = usersignup.Pincode;
            details.Adress = usersignup.Adress;
            details.Username = usersignup.Username;
            details.Pswrd = usersignup.Pswrd;

            _context.SaveChanges();
            return Ok("Details Updated");
        }


        [HttpDelete]
        public IActionResult Delete(string username)
        {
            var usersign = _context.Usersignups.Find(username);
            if (usersign == null)
            {
                return NotFound($"user not found with username {username}");
            }
            _context.Usersignups.Remove(usersign);
            _context.SaveChanges();
            return Ok("User deleted");
        }

    }
}
