﻿using Microsoft.AspNetCore.Mvc;
using WebAPI9.Models;

namespace WebAPI9.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {
       [HttpGet]
       public IActionResult GetSmjerovi()
        {
            List<Smjer> smjerovi = new List<Smjer>();







            return Ok(new smjerovi());
        }

    }
}
