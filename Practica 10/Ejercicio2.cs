using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int Opcion;


            Console.Clear();
            Console.WriteLine("Menú de opciones");
            Console.WriteLine("\n1) Agregar país");
            Console.WriteLine("\n2) Mostrar países");
            Console.WriteLine("\n3) Buscar país");
            Console.WriteLine("\n4) Salir");


            Opcion = Convert.ToInt32(Console.ReadLine());
            switch (Opcion)
            {
                case 1:
                    Console.Clear();
                    StreamWriter ArchivoAgregar = new StreamWriter("Arreglo.txt", true);
                    string[] Paises;
                    int Cantidad;
                    string NombrePais;
                    Console.Write("Cantidad de paises que desea agregar: ");
                    Cantidad = Convert.ToInt32(Console.ReadLine());
                    Paises = new string[Cantidad];
                    for (int i = 1; i <= Cantidad; i++)
                    {
                        Console.Write("Pais: ");
                        NombrePais = Console.ReadLine();
                        ArchivoAgregar.WriteLine(NombrePais);
                    }

                    Console.Write("Presione <ENTER> para salir");
                    ArchivoAgregar.Close();
                    Console.ReadKey();
                    break;

                case 2:
                    //Mostrar pais

                    string Pais;
                    StreamReader ArchivoMostrar = new StreamReader("ArchivoPaises.txt");
                    Console.Clear();
                    Pais = ArchivoMostrar.ReadToEnd();
                    int Indice = 0;
                    Indice++;
                    Console.Write("{0}) {1}", Indice + 1, Pais);
                    Console.Write("\nPresione <Enter> para salir");
                    ArchivoMostrar.Close();
                    Console.ReadKey();
                    break;

                case 3:
                    //Buscar pais

                    StreamReader ArchivoBuscar = new StreamReader("ArchivoPaises.txt");
                    string text;
                    string BuscarPais;
                    Console.Clear();
                    Console.WriteLine("Ingrese el país que desea buscar: ");
                    BuscarPais = Console.ReadLine();

                    do
                    {
                        text = ArchivoBuscar.ReadLine();


                        if (text != null)
                        {
                            if (text.Equals(BuscarPais))
                            {

                                Console.Clear();
                                Console.WriteLine("'{0}' si se encutra almacenado en el archivo", BuscarPais);


                            }

                            else
                            {
                                Console.Clear();
                                Console.Write("'{0}' no se encutra almacenado en el archivo", BuscarPais);
                                Console.WriteLine("\nPresione <ENTER> para salir");
                                Console.ReadKey();
                            }


                        }


                    } while (text != null);
                    Console.WriteLine("\nPresione <ENTER> para continuar");
                    Console.ReadKey();


                    break;

                case 4:
                    //Salir

                    Console.Clear();
                    Console.WriteLine("Presione <ENTER> para salir");
                    Console.ReadKey();

                    break;



            }

        }

    }
}