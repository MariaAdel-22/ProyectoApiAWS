using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoApiAWS.Models;
using ProyectoApiAWS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoApiAWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CochesController : ControllerBase
    {
        private RepositoryCoches repoCoches;

        public CochesController(RepositoryCoches repoCoches) {

            this.repoCoches = repoCoches;
        }

        [HttpGet]
        public ActionResult<List<Coche>> GetCoches() {

            return this.repoCoches.GetCoches();
        }

        [HttpGet("{id}")]
        public ActionResult<Coche> FindCoche(string id) {

            return this.repoCoches.BuscarCoche(id);
        }

        [HttpPost]
        public ActionResult InsertCoche(Coche coche) {

            this.repoCoches.InsertarCoche(coche.Marca, coche.Modelo, coche.Imagen);

            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateCoche(Coche coche) {

            this.repoCoches.ModificarCoche(coche.Marca, coche.Modelo, coche.Imagen);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCoche(string id) {

            this.repoCoches.EliminarCoche(id);

            return Ok();
        }
    }
}
