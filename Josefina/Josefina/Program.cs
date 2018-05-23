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
        
        

        
        static void Main(string[] args)
        {

			Metodos metodos = new Metodos();

			List<ClassLibrary1.Person> Personas = metodos.Personas;
			List<ClassLibrary1.Car> Autos = metodos.Autos;
			List<ClassLibrary1.Address> Direcciones = metodos.Direcciones;

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
					usuario = metodos.AgregarPersona();
                }
            }

            if( r1 == "2")
            {
				ClassLibrary1.Person usuario = metodos.AgregarPersona();

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
                        "\n3. Cambiar el dueño del domicilio" +
	                    "\n4. Ingresar un nuevo domicilio\n");

					string r3 = Console.ReadLine();
                    if (r3 == "1")
					{
						int a = 0;
						foreach (ClassLibrary1.Address d in Direcciones)
						{
							a += 1;
							Console.WriteLine(a.ToString() + "\n" + d.Street + " " + d.Number + ", " + d.Commune + ", " + d.City);
                            
						}

						Console.WriteLine("Ingrese el numero de la direccion a la cual desea agregar habitaciones");
						int r4 = Convert.ToInt32(Console.ReadLine());
						a = 0;
						ClassLibrary1.Address domicilio = null;
						foreach (ClassLibrary1.Address d in Direcciones)
                        {
                            a += 1;
							if (a == r4)
							{
								domicilio = d;
                                
							}

                        }

                       
						if (domicilio != null)
						{
							Console.WriteLine("Ingrese la cantidad que desea agregar");
                            int banos = Convert.ToInt32(Console.ReadLine());
							domicilio.addBeedrooms(banos);
						}

						else
						{
							Console.WriteLine("El numero ingresado es incorrecto");
						}

							
					}

                    if(r3 == "2")
					{
						int a = 0;
                        foreach (ClassLibrary1.Address d in Direcciones)
                        {
                            a += 1;
                            Console.WriteLine(a.ToString() + "\n" + d.Street + " " + d.Number + ", " + d.Commune + ", " + d.City);

                        }

                        Console.WriteLine("Ingrese el numero de la direccion a la cual desea agregar baños");
                        int r4 = Convert.ToInt32(Console.ReadLine());
                        a = 0;
                        ClassLibrary1.Address domicilio = null;
                        foreach (ClassLibrary1.Address d in Direcciones)
                        {
                            a += 1;
                            if (a == r4)
                            {
                                domicilio = d;

                            }

                        }


                        if (domicilio != null)
                        {
                            Console.WriteLine("Ingrese la cantidad que desea agregar");
                            int habitaciones = Convert.ToInt32(Console.ReadLine());
                            domicilio.addBeedrooms(habitaciones);
                        }

                        else
                        {
                            Console.WriteLine("El numero ingresado es incorrecto");
                        }
					}

                    if (r3 == "3")
					{

						int a = 0;
                        foreach (ClassLibrary1.Address d in Direcciones)
                        {
                            a += 1;
                            Console.WriteLine(a.ToString() + "\n" + d.Street + " " + d.Number + ", " + d.Commune + ", " + d.City);

                        }

                        Console.WriteLine("Ingrese el numero de la direccion a la cual desea agregar baños");
                        int r4 = Convert.ToInt32(Console.ReadLine());
                        a = 0;
                        ClassLibrary1.Address domicilio = null;
                        foreach (ClassLibrary1.Address d in Direcciones)
                        {
                            a += 1;
                            if (a == r4)
                            {
                                domicilio = d;

                            }

                        }

						if (domicilio != null)
						{
							Console.WriteLine("El nuevo dueños esta registrado? 1.Si / 2.No \n");
                            string r5 = Console.ReadLine();

                            ClassLibrary1.Person nuevodueno = null;

                            if (r5 == "1")
                            {
                                Console.WriteLine("Ingrese su rut");
                                string r = Console.ReadLine();
                                nuevodueno = metodos.Persona(r);

                                if (nuevodueno == null)
                                {
                                    Console.WriteLine("El rut ingresado no esta registrado");

                                }

                            }

                            if (r5 == "2")
                            {
                                nuevodueno = metodos.AgregarPersona();
                            }
						}

						else
                        {
                            Console.WriteLine("El numero ingresado es incorrecto");
                        }



					}

					if (r3 == "4")
					{
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

						ClassLibrary1.Address direccion = new ClassLibrary1.Address(calle, numero, comuna, ciudad, usuario, ano, habitaciones, banos, patio, piscina);
						Console.WriteLine("Domicilio ingresado!");
						
					}
                }

                if( r2 == "2")
				{
					Console.WriteLine("Ingrese el numero la opcion que desea llevar acabo: " +
									  "\n1. Cambiar dueño" +
									  "\n2. Ingresar educacion" +
									  "\n3. Eliminar padres" +
									  "\n4. Ser adoptado por una persona" +
									  "\n5. Ser adoptado por dos personas" +
									  "\n6. Cambiar primer nombre" +
									  "\n7. Cambiar apellido " +
					                  "\n8. Registrar un nuevo usuario\n");

					string r6 = Console.ReadLine();

                    if (r6 == "1")
					{
						Console.WriteLine("El nuevo dueños esta registrado? 1.Si / 2.No \n");
                        string r7 = Console.ReadLine();

                        ClassLibrary1.Person nuevodueno = null;

                        if (r7 == "1")
                        {
                            Console.WriteLine("Ingrese su rut");
                            string r = Console.ReadLine();
                            nuevodueno = metodos.Persona(r);

                            if (nuevodueno == null)
                            {
                                Console.WriteLine("El rut ingresado no esta registrado");

                            }

                        }

                        if (r7 == "2")
                        {
                            nuevodueno = metodos.AgregarPersona();
                        }

						usuario.giveUpOwnershipToThirdParty(nuevodueno);
					}

                    else if(r6 == "2")
					{
						Console.WriteLine("Ingrese su titulo profesional \nIngrese alma mater\n");
						string titulo = Console.ReadLine();
						string alma = Console.ReadLine();

						usuario.setEducation(alma, titulo);
					}
                    
					else if (r6 == "3")
					{
						usuario.getAbandoned();
					}

					else if (r6 == "4")
					{
						Console.WriteLine("Su padre adoptivo esta registrado? 1.Si / 2.No \n");
                        string r7 = Console.ReadLine();

                        ClassLibrary1.Person nuevopadre = null;

                        if (r7 == "1")
                        {
                            Console.WriteLine("Ingrese su rut");
                            string r = Console.ReadLine();
                            nuevopadre = metodos.Persona(r);
                            
                            if (nuevopadre == null)
                            {
                                Console.WriteLine("El rut ingresado no esta registrado");

                            }

                        }
                        
                        if (r7 == "2")
                        {
                            nuevopadre = metodos.AgregarPersona();
                        }

						usuario.getAdopted(nuevopadre);
                    
					}

					else if (r6 == "5")
					{
						Console.WriteLine("Su primer padre adoptivo esta registrado? 1.Si / 2.No \n");
                        string r7 = Console.ReadLine();

                        ClassLibrary1.Person nuevopadre1 = null;

                        if (r7 == "1")
                        {
                            Console.WriteLine("Ingrese su rut");
                            string r = Console.ReadLine();
                            nuevopadre1 = metodos.Persona(r);

                            if (nuevopadre1 == null)
                            {
                                Console.WriteLine("El rut ingresado no esta registrado");

                            }

                        }

                        if (r7 == "2")
                        {
                            nuevopadre1 = metodos.AgregarPersona();
                        }

						Console.WriteLine("Su segundo padre adoptivo esta registrado? 1.Si / 2.No \n");
                        string r8 = Console.ReadLine();

                        ClassLibrary1.Person nuevopadre2 = null;

                        if (r8 == "1")
                        {
                            Console.WriteLine("Ingrese su rut");
                            string r = Console.ReadLine();
                            nuevopadre2 = metodos.Persona(r);

                            if (nuevopadre2 == null)
                            {
                                Console.WriteLine("El rut ingresado no esta registrado");

                            }

                        }
                        
                        if (r8 == "2")
                        {
                            nuevopadre2 = metodos.AgregarPersona();
                        }

						usuario.getAdopted(nuevopadre1, nuevopadre2);
					}

					else if (r6 == "6")
					{
						Console.WriteLine("Ingrese su nuevo nombre");
						string n = Console.ReadLine();
						usuario.changeFirstName(n);
					}

					else if (r6 == "7")
                    {
                        Console.WriteLine("Ingrese su nuevo apellido");
                        string a = Console.ReadLine();
                        usuario.changeLastName(a);
                    }

					else if (r6 == "8")
					{
						metodos.AgregarPersona();
					}
						
				}

				else if(r2 == "3")
				{
					Console.WriteLine("Desea registrar un auto? 1.Si / 2.No");
					string r9 = Console.ReadLine();
                    if (r9 == "1")
					{
						Console.WriteLine("Ingrese: \n " +
										  "Modelo: \n " +
										  "Marca: \n " +
										  "Patente: \n " +
										  "Año: \n" +
										  "Cantidad de cinturones " +
										  "Disel? 1.SI / 2.No\n ");
						
						string modelo = Console.ReadLine();
						string marca = Console.ReadLine();
						string patente = Console.ReadLine();
						int ano = Convert.ToInt32(Console.ReadLine());
						int cinturones = Convert.ToInt32(Console.ReadLine());
						string disel = Console.ReadLine();
						bool d = false;
						if (disel == "1")
						{
							d = true;
						}

						ClassLibrary1.Car Auto = new ClassLibrary1.Car(marca, modelo, ano, usuario, patente, cinturones, d);


					}
					Console.WriteLine("Desea cambiar el nueño del auto? 1.SI / 2.No");
					string r8 = Console.ReadLine();

                    if (r8 == "1")
					{
						Console.WriteLine("Ingrese la patente del auto\n");
						string patente = Console.ReadLine();
						ClassLibrary1.Car auto = metodos.Auto(patente);
					}
				}
                                        
            }

        }
    }
}
