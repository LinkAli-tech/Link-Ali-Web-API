using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using WebApi.Models;
using WebApi.Models.Quote;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : ControllerBase
    {
        private IUserService _userService;

        public QuotesController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("submitQuote")]
        [AllowAnonymous]
        public IActionResult submitQuote([FromBody]Quote quote)
        {
            try
            {
                // save 
                _userService.SubmitRequirement(quote);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("admin/quote/{id}")]
        public IActionResult GetByQuoteById(int id)
        {
            var quote = _userService.GetRequirementById(id);
            return Ok(quote);
        }

        [HttpGet("admin/quotes")]
        public IActionResult GetAllQuotes()
        {
            var users = _userService.FetchAllRequirements();
            return Ok(users);
        }

    }
}