using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PowersController : ControllerBase
    {
        IPowerService _powerService;

        public PowersController(IPowerService powerService)
        {
            _powerService = powerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _powerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addpower")]
        public IActionResult Add(Power power)
        {
            var result = _powerService.Add(power);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deletepower")]
        public IActionResult Delete(Power power)
        {
            var result = _powerService.Delete(power);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updatepower")]
        public IActionResult Update(Power power)
        {
            var result = _powerService.Update(power);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
