using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemperatureController : ControllerBase
    {
             private readonly DataContext _context;
        public TemperatureController(DataContext context)
        {
             _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TemperatureConstraints>>> GetAllBuildingTemperature(){
            return await _context.TemperatureConstraints.ToListAsync(); 
        }

        //get temperature based on the room type: conference room or normal room
        [HttpGet("{roomType}")]
        public async Task<ActionResult<TemperatureConstraints>> GetFloorTemeratureBasedOnRoom(string roomType){
            return await  _context.TemperatureConstraints.Where(r => r.roomType == roomType).FirstOrDefault();
        }
    }
}