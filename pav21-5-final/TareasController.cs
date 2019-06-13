using System;
using ListaTareasEntidades;
using ListaTareas.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ListaTareas.Web.Controllers
{
    public class TareasController : ApiController
    {
        // GET: api/Tareas
        public IEnumerable<Tareas> Get(int idTipo, bool? completado)
        {
            completado = null;
            return GestorTareas.GetTareas(idTipo,completado);
        }

        // GET: api/Tareas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tareas
        public void Post(Tareas t)
        {
            GestorTareas.crearTarea(t);

        }

        // PUT: api/Tareas/5
        public void Put(int id, Tareas t)
        {
            GestorTareas.actualizarTarea(t);
        }

        // DELETE: api/Tareas/5
        public void Delete(int id)
        {
            GestorTareas.eliminarTarea(id);
        }
    }
}
