using BlazorAppVS.Server.Helpers;
using BlazorAppVS.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppVS.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorDeArchivos almacenadorDeArchivos;

        public PeopleController(ApplicationDbContext context, IAlmacenadorDeArchivos almacenadorDeArchivos)
        {
            this.context = context;
            this.almacenadorDeArchivos = almacenadorDeArchivos;
        }

        [HttpGet]
        public async Task<ActionResult<List<People>>> Get()
        {
            return await context.Peoples.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(People people)
        {
            if (!string.IsNullOrWhiteSpace(people.Foto))
            {
                var fotoPeople = Convert.FromBase64String(people.Foto);
                people.Foto = await almacenadorDeArchivos.GuardarArchivo(fotoPeople, "jpg", "personas");
            }
            context.Add(people);
            await context.SaveChangesAsync();
            return people.Id;
        }
    }
}
