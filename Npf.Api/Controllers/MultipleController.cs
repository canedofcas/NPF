using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Npf.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Npf.Api.Controllers
{
    [Route("multiple")]
    [ApiController]
    public class MultipleController : ControllerBase
    {
        [Route("")]
        [HttpPost]
        public IActionResult IsMultiple([FromBody] Number num)
        {
            var result = Helper.Helpers.IsMultipleOfEleven(num).ToList();
            return Ok( new
            {
                result = result
            });
        }

    }
}
