using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyDataServer.Data;
using FamilyDataServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace FamilyDataServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
         private readonly IAdultData adultData;

        public AdultController(IAdultData adultData)
        {
            this.adultData = adultData;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults([FromQuery] int? id, [FromQuery] string? name, [FromQuery] string? hairColor, [FromQuery] string? eyeColor, [FromQuery] string? sex, [FromQuery] int? age)
        {
            try
            {
                IList<Adult> adults = await adultData.GetAdults();
                ActionResult<IList<Adult>> adultsToShow = new List<Adult>();
                if (id != null)
                {
                    adultsToShow = adults.Where(a => a.Id == id).ToList();
                    return adultsToShow;
                }
                if (name != null)
                {
                    adultsToShow = adults.Where(a => (a.FirstName + "" + a.LastName).ToLower().Contains(name)).ToList();
                    return adultsToShow;
                }
                if (hairColor != null)
                {
                    adultsToShow = adults.Where(a => a.HairColor.ToLower().Contains(hairColor)).ToList();
                    return adultsToShow;
                }
                if (eyeColor != null)
                {
                    adultsToShow = adults.Where(a => a.EyeColor.ToLower().Contains(eyeColor)).ToList();
                    return adultsToShow;
                }
                if (sex != null)
                {
                    adultsToShow = adults.Where(a => a.Sex.ToLower().Contains(sex)).ToList();
                    return adultsToShow;
                }
                if (age != null)
                {
                    adultsToShow = adults.Where(a => a.Age == age).ToList();
                    return adultsToShow;
                }
                else
                {
                    return Ok(adults);
                
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Adult newAdult = await adultData.AddAdult(adult);
                return Created($"/{newAdult.Id}", newAdult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> RemoveAdult([FromRoute] int id)
        {
            try
            {
                await adultData.RemoveAdult(id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPatch]
        [Route("{id:int}")]
        public async Task<ActionResult<Adult>> UpdateAdult([FromBody] Adult adult) 
        {
            try
            {
                Adult adultToUpdate = await adultData.UpdateAdult(adult);
                return Ok(adultToUpdate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Adult>> GetAdult([FromRoute] int? id)
        {
            try
            {
                Adult adult = await adultData.Get((int) id);
                return Ok(adult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}