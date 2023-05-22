using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }



        [HttpGet("getall")]
        public IActionResult GetAll()       //IACTIONRESULT FARKLI HTTP KODLARI DONDURMEMIZI SAGLAR.
        {


            var result = _rentalService.GetAll();
            if (result.Success)
            {

                return Ok(result);//Result i Ok donuyor
            }

            return BadRequest(result);//Result i BadRequest donuyor.

        }


        [HttpPost("add")]

        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
                if (result.Success)
            {

                return Ok(result);
            }

            return BadRequest(result);
        
         }


        [HttpPost("delete")]

        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success)
            {

                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpPost("update")]

        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success)
            {

                return Ok(result);
            }

            return BadRequest(result);

        }


    }
}
