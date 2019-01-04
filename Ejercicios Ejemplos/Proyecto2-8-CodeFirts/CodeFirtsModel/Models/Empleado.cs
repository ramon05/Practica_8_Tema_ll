using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirtsModel.Models
{
	public class Empleado
	{
		public int EmpleadoID { get; set; }
		public String Nombres { get; set; }
		public string Apellido { get; set; }
		public  Nullable<System.DateTime> Fecha_Ingreso { get; set; }
		public virtual ICollection<Registro> Registros { get; set; }

	}
}
