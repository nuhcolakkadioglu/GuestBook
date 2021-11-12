using GuestBook.Business.Abstract;
using GuestBook.Core.Dtos.GuestPost;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuestBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestPostController : ControllerBase
    {
        private readonly IGuestPostService _guestPostService;

        public GuestPostController(IGuestPostService guestPostService)
        {
            _guestPostService = guestPostService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _guestPostService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _guestPostService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(GuestPostCreateDto model)
        {
            var result = _guestPostService.Add(model);
            return Created("", result);
        }


        [HttpPut]
        public IActionResult Update(GuestPostUpdateDto model)
        {
            var result = _guestPostService.Update(model);
            return Created("", result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _guestPostService.Delete(id);
            return NoContent();
        }

    }
}
