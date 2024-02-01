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
    public class BusInventoriesController : ControllerBase
    {
        private readonly OnlineBusBookingDbContext _context;

        public BusInventoriesController(OnlineBusBookingDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var busdetails = _context.BusInventories.ToList();
            return Ok(busdetails);
        }
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                var busdetail = _context.BusInventories.Find(id);
                if (busdetail == null)
                {
                    return NotFound($"busdeatils not found with id {id}");
                }
                return Ok(busdetail);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Post(BusInventory businventory)
        {
            _context.Add(businventory);
            _context.SaveChanges();
            return Ok("Bus Details Created");
        }
        [HttpPut]
        public IActionResult Put(BusInventory businventory)
        {
            if (businventory == null)
            {
               
                return BadRequest($"Booking id {businventory.BusId} is invalid");
                
            }

            var busdetail = _context.BusInventories.Find(businventory.BusId);
            if (busdetail == null)
            {
                return NotFound($"BusDetails not found with bookingid {businventory.BusId}");
            }
            busdetail.BusName = businventory.BusName;
            busdetail.BusCategory = businventory.BusCategory;
            busdetail.AvailabilitySeats = businventory.AvailabilitySeats;
            busdetail.Boarding = businventory.Boarding;
            busdetail.Departure = businventory.Departure;
            busdetail.StartTime = businventory.StartTime;
            busdetail.EndTime = businventory.EndTime;
            busdetail.Price = businventory.Price;
            _context.SaveChanges();
            return Ok("BusDetails Updated");
        }
        [HttpDelete]
        public IActionResult Delete(string id)
        {
            try
            {
                var busdetail = _context.BusInventories.Find(id);
                if (busdetail == null)
                {
                    return NotFound($"BusDetails not found with BusId {id}");
                }
                _context.BusInventories.Remove(busdetail);
                _context.SaveChanges();
                return Ok("Busdetails deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
