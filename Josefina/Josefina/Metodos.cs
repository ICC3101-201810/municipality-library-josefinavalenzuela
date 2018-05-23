using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using ClassLibrary1;
using System.Runtime.Serialization.Formatters.Binary;



namespace Josefina
{
	public class Metodos
	{
		public List<ClassLibrary1.Person> Personas = new List<ClassLibrary1.Person>();
		public List<ClassLibrary1.Car> Autos = new List<ClassLibrary1.Car>();
		public List<ClassLibrary1.Address> Direcciones = new List<ClassLibrary1.Address>();

		public Metodos()
		{
		}

		public ClassLibrary1.Person Persona(string rut)
		{
			foreach (ClassLibrary1.Person p in Personas)
			{
				if (p.Rut == rut)
				{
					return p;
				}
			}

			return null;
		}

		public ClassLibrary1.Car Auto(string patente)
		{
			foreach (ClassLibrary1.Car c in Autos)
			{
				if (c.License_plate == patente)
				{
					return c;
				}
			}

			return null;
		}



		public ClassLibrary1.Person AgregarPersona()
		{
			Console.WriteLine("Ingrese su rut\n");
			string rut = Console.ReadLine();
			Console.WriteLine("Ingrese su nombre\n");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese su apellido\n");
			string apellido = Console.ReadLine();
			Console.WriteLine("Ingrese su fecha de nacimiento (DD-MM-AAAA)\n");
			DateTime nacimiento = Convert.ToDateTime(Console.ReadLine());
			Console.WriteLine("Ingrese el rut de uno de sus padres (si no esta registrado intregese 0)");
			string rutp1 = Console.ReadLine();
			ClassLibrary1.Person p1 = null;

			foreach (ClassLibrary1.Person p in Personas)
			{
				if (rut == p.Rut)
				{
					p1 = p;
				}
			}

			Console.WriteLine("Ingrese el rut de su otro padre (si no esta registrado intregese 0)");
			string rutp2 = Console.ReadLine();
			ClassLibrary1.Person p2 = null;

			foreach (ClassLibrary1.Person p in Personas)
			{
				if (rut == p.Rut)
				{
					p2 = p;
				}
			}

			Console.WriteLine("Para registrar su direccion, debe ingresar: \n1. Calle " +
				"\n2. Numero " +
				"\n3. Ciudad " +
				"\n4. Año de construccion " +
				"\n5. Cantidad de habitaciones" +
				"\n6. Tiene piscina? Si/No " +
				"\n7. Cantidad de baños" +
				"\n8. Tiene patio? Si/No\n" +
				"\n9. Comuna"
				);

			string calle = Console.ReadLine();
			int numero = Convert.ToInt32(Console.ReadLine());
			string ciudad = Console.ReadLine();
			int ano = Convert.ToInt32(Console.ReadLine());
			int habitaciones = Convert.ToInt32(Console.ReadLine());

			bool piscina = false;
			if (Console.ReadLine() == "Si")
			{
				piscina = true;
			}


			int banos = Convert.ToInt32(Console.ReadLine());
			bool patio = false;
			if (Console.ReadLine() == "Si")
			{
				patio = true;
			}


			string comuna = Console.ReadLine();

			ClassLibrary1.Address direccion = new ClassLibrary1.Address(calle, numero, comuna, ciudad, null, ano, habitaciones, banos, patio, piscina);
			ClassLibrary1.Person usuario = new ClassLibrary1.Person(nombre, apellido, nacimiento, direccion, rut, p1, p2);
			direccion.changeOwner(usuario);


			return usuario;
		}

	}
}
