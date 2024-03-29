﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardsController : ControllerBase
    {
        ICreditCardService _creditCardService;

        public CreditCardsController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }


        [HttpPost("add")]
        public IActionResult Add(CreditCard creditCard)
        {
            var result = _creditCardService.Add(creditCard);
            if (result.Success)
            {

                return Ok(result);
            }

            else
            {
                return BadRequest(result);
            }


        }


        [HttpPost("delete")]
        public IActionResult Delete(CreditCard creditCard)
        { 
        
            var result=_creditCardService.Delete(creditCard);
            if (result.Success)
            {

                return Ok(result);
            }

            else
            {

                return BadRequest(result);
            }
        
        }



        [HttpPost("update")]
        public IActionResult Update(CreditCard creditCard)

        {

            var result = _creditCardService.Update(creditCard);
            if (result.Success)
            {

                return Ok(result);
            }

            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getcustomerscreditcards")]
        public IActionResult GetCustomerCreditCards(int customerId)
        { 
        
            var result=_creditCardService.GetCreditCardsByCustomerId(customerId);
            if (result.Success)
            {
                return Ok(result);

            }

            else
            {
                return BadRequest(result);
            }
        }
    }
}
