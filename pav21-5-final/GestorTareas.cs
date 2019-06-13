using System;
using ListaTareasEntidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTareas.Datos
{
    public static class GestorTareas
    {
        public static List<Tareas> GetTareas(int idTipo = 0, bool? completado = null)
        {
            ListaTareasDB db = new ListaTareasDB();
            var dbTareas = db.DBTareas;

            //var listaTareas = from t in db.DBTareas select new Tareas(){ Id = t.Id, Nombre = t.Nombre, Completado=t.Completado,FechaVencimiento=t.FechaVencimiento,Tipo= new Tipo {Id=t.Tipo.Id,Nombre=t.Tipo.Nombre } };

            //return listaTareas.ToList();

            var listaTareas = db.DBTareas.Select(t => new Tareas { Id = t.Id, Nombre = t.Nombre, Completado = t.Completado, FechaVencimiento = t.FechaVencimiento, Tipo = new Tipo { Id = t.Tipo.Id, Nombre = t.Tipo.Nombre } })
                .Where(t => (t.Tipo.Id == idTipo || idTipo == 0) && (t.Completado == completado || completado == null))
                .OrderByDescending(t => t.FechaVencimiento);
            return listaTareas.ToList();
        }

        public static void crearTarea(Tareas t)
        {
            ListaTareasDB db = new ListaTareasDB();
            var tdb = new DBTarea()
            {
                Nombre= t.Nombre,
                FechaVencimiento= t.FechaVencimiento,
                Completado= t.Completado,
                TipoId=t.Tipo.Id,
            };
            db.DBTareas.Add(tdb);
            db.SaveChanges();
        }
        public static void actualizarTarea (Tareas t)
        {
            ListaTareasDB db = new ListaTareasDB();
            var tdb = db.DBTareas.Find(t.Id);
            if(tdb != null)
            {
                tdb.Nombre = t.Nombre;
                tdb.FechaVencimiento = t.FechaVencimiento;
                tdb.Completado = t.Completado;
                tdb.TipoId = t.Tipo.Id;
                db.SaveChanges();
            }
        }
        public static void eliminarTarea (int id)
        {
            ListaTareasDB db = new ListaTareasDB();
            var tdb = db.DBTareas.Find(id);
            if (tdb != null)
            {
                db.DBTareas.Remove(tdb);
                db.SaveChanges();
            }
        }


        

    }
}
