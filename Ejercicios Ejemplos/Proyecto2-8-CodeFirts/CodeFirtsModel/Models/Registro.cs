using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirtsModel.Models
{
	public class Registro
	{
		public int RegistroID { get; set; }
		public Nullable<decimal> Sueldo { get; set; }
		public int DepartamentoID { get; set; }
		public int EmpleadoID { get; set; }

		public  virtual Departamento Departamento { get; set; }
		public virtual Empleado Empleado { get; set; }
	}
}
