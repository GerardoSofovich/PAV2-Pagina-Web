using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ListaTareas.Datos;
using ListaTareasEntidades;

namespace ListaTareas.Web.Controllers
{
    public class TiposController : ApiController
    {
        // GET: api/Tipos

        public List<Tipo> Get()
        {
			return GestorTipos.GetTipos();
        }

        // GET: api/Tipos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tipos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tipos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tipos/5
        public void Delete(int id)
        {
        }
    }
}
