using ListaTareasEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTareas.Datos
{
	public static class GestorTipos
	{
		public static List<Tipo>GetTipos()
		{
			ListaTareasDB db = new ListaTareasDB();
			var dbTipos = db.DBTipos;

			var listaTipos = new List<Tipo>();

			foreach (var t in dbTipos)
			{
				listaTipos.Add(new Tipo()
				{
					Id = t.Id,
					Nombre = t.Nombre
				});
					
			}
			return listaTipos;
		}
	}
}
