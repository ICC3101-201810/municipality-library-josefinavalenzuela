using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Josefina
{
    class Program
    {
        
        public static List<ClassLibrary1.Person> AgregarPersona(List<ClassLibrary1.Person> Personas)
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
        }

        public static List<>
        static void Main(string[] args)
        {

            

            List<ClassLibrary1.Person> Personas = new List<ClassLibrary1.Person>();
            List<ClassLibrary1.Car> Autos = new List<ClassLibrary1.Car>();
            List<ClassLibrary1.Address> Direcciones = new List<ClassLibrary1.Address>();
            Console.WriteLine("Esta usted registrado? \n1. Si \n2. No \n");
            string r1 = Console.ReadLine();
            if (r1 == "1")
            {
                Console.WriteLine("Ingrese su rut\n");
                string rut = Console.ReadLine();
                ClassLibrary1.Person usuario = null;
                foreach(ClassLibrary1.Person p in Personas)
                {
                    if(rut == p.Rut)
                    {
                        usuario = p;
                    }
                }

                if (usuario != null)
                {
                    Console.WriteLine("Usuario ingresaddo correctamente");
                }

                else
                {
                    Console.WriteLine("Usuario no registrado");
                    r1 = "2";
                }
            }

            if( r1 == "2")
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
                if(Console.ReadLine() == "Si")
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

                Console.WriteLine("Ingrese el numero de la accion que desea realizar: " +
                    "\n1. Respecto a su domicilio" +
                    "\n2. Respecto a su informacion personal" +
                    "\n3. Respecto a su auto\n"
                    );
                string r2 = Console.ReadLine();
                if (r2 == "1")
                {
                    Console.WriteLine("Desea: \n" +
                        "1. Agregar habitaciones" +
                        "\n2. Agregar baños" +
                        "\n3. Cambiar el dueño de ");
                }










            }

        }
    }
}
