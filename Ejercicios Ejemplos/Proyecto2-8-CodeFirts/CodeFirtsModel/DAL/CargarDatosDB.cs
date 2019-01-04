using CodeFirtsModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirtsModel.DAL
{
	class CargarDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmpleadoContext>
	{

		protected override void Seed(EmpleadoContext context)
		{
			var Departamentos = new List<Departamento>
			{
				new Departamento{DepartamentoID=1, Descripcion="Programación",},
				new Departamento{DepartamentoID=2, Descripcion="Recursos Humanos",},
				new Departamento{DepartamentoID=3, Descripcion="Mercadeo",}
			};
			Departamentos.ForEach(s => context.Departamentos.Add(s));
			context.SaveChanges();

			var Empleados = new List<Empleado>
			{
				new Empleado{Nombres="Juan Carlos", Apellido="Reyes Jimenez", Fecha_Ingreso=DateTime.Parse("2001-09-01")},
				new Empleado{Nombres="Belkis", Apellido="Sandoval Polanco", Fecha_Ingreso=DateTime.Parse("2002-10-25")},
				new Empleado{Nombres="Jean Carlos", Apellido="Reyes Sandoval", Fecha_Ingreso=DateTime.Parse("2003-01-16")},
				new Empleado{Nombres="Josue", Apellido="Reyes Sandoval", Fecha_Ingreso=DateTime.Parse("2003-09-15")}
			};
			Empleados.ForEach(s => context.Empleados.Add(s));
			context.SaveChanges();

			var Registros = new List<Registro>
			{
				new Registro{EmpleadoID=1, DepartamentoID=1, Sueldo=Convert.ToDecimal(100000.00)},
				new Registro{EmpleadoID=2, DepartamentoID=1, Sueldo=Convert.ToDecimal(25000.00)},
				new Registro{EmpleadoID=3, DepartamentoID=2, Sueldo=Convert.ToDecimal(15400.00)},
				new Registro{EmpleadoID=4, DepartamentoID=2, Sueldo=Convert.ToDecimal(12500.00)}
			};
			Registros.ForEach(s => context.Registros.Add(s));
			context.SaveChanges();
		}
	}
}
