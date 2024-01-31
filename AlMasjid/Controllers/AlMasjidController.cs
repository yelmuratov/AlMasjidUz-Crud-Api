using AlMasjid.Data;
using AlMasjid.Entities;
using AlMasjid.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlMasjid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlMasjidController : ControllerBase
    {
        private readonly DataContext _context;
        public AlMasjidController(DataContext context)
        {
            _context = context;
        }

        //Get All mosques
        [HttpGet]
        public async Task<ActionResult<List<Almasjid>>> GetAllMosques()
        {
            var mosques = await _context.Mosques.ToListAsync();
            return Ok(mosques);
        }

        [HttpGet("{id}")]

        //Get mosque using Id
        public async Task<ActionResult<Almasjid>> GetMosqueById(int id)
        {
            var mosque = await _context.Mosques.FindAsync(id);

            if (mosque is null)
                return NotFound("Mosque not found");
            return Ok(mosque);
        }

        interface IMosque {
            string name { get; set; }
            double Longitude { get; set; }
            double Latitude { get; set; }
            string Fajr { get; set; }
            string Duhr { get; set; }
            string Asr { get; set; }
            string Magrib { get; set; }
            string Isha { get; set; }
        }


        //Add mosque
        [HttpPost]
        public async Task<ActionResult<List<Almasjid>>> Addmosque(Almasjid mosque)
        {
            _context.Mosques.Add(mosque);
            await _context.SaveChangesAsync();
            return Ok(await _context.Mosques.ToListAsync());
        }

        //Update Mosque
        [HttpPut]
        public async Task<ActionResult<List<Almasjid>>> Updatemosque(Almasjid updatedMosque)
        {
            var dbMosques = await _context.Mosques.FindAsync(updatedMosque.Id);

            if (dbMosques is null) 
                return NotFound("Mosque not found");

            dbMosques.name = updatedMosque.name;
            dbMosques.Longitude = updatedMosque.Longitude;
            dbMosques.Latitude= updatedMosque.Latitude;
            dbMosques.Fajr = updatedMosque.Fajr;
            dbMosques.Duhr = updatedMosque.Duhr;
            dbMosques.Asr = updatedMosque.Asr;
            dbMosques.Magrib = updatedMosque.Magrib;
            dbMosques.Isha = updatedMosque.Isha;

            await _context.SaveChangesAsync();
            return Ok(await _context.Mosques.ToListAsync());
        }

        //Remove mosque
        [HttpDelete]
        public async Task<ActionResult<List<Almasjid>>> DeleteMosque(int id)
        {
            var dbMosque = await _context.Mosques.FindAsync(id);
            if (dbMosque is null)
                return NotFound("Mosque not found");

            _context.Mosques.Remove(dbMosque);
            await _context.SaveChangesAsync();
            return Ok(await _context.Mosques.ToListAsync());
        }




    }
}
