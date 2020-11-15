using BlazorAppVS.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppVS.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenderController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public GenderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Gender gender)
        {
            context.Add(gender);
            await context.SaveChangesAsync();
            //return Ok();
            return gender.Id;
        }
    }
}
