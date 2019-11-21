using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int Opcion;

            Console.Clear();
            Console.WriteLine("Menú de opciones");
            Console.WriteLine("\n1) Registrarse");
            Console.WriteLine("\n2) Salir\n");
            

            Opcion = Convert.ToInt32(Console.ReadLine());
            switch (Opcion)
            {
                case 1:
                    //Registro
                    StreamWriter ArchivoRegistrar = new StreamWriter("Usuarios.txt", true);

                    string NombreUsuario, Contraseña, VerificarContraseña;


                    Console.Clear();
                    Console.Write("Nombre de Usuario: ");
                    NombreUsuario = Console.ReadLine();
                    Console.WriteLine("\nUsuario Registrado exitosamente");
                    Console.ReadKey();





                    Console.Clear();
                    Console.WriteLine("Usuario: {0}", NombreUsuario);
                    Console.Write("Contraseña: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Contraseña = Console.ReadLine();
                    Console.ResetColor();
                    if (Contraseña.Length < 7 || Contraseña.Length > 20)
                    {

                        Console.Write(" La contraseña debe tener entre 7 y 20 caracteres");
                        Console.ReadKey();
                    }
                    else
                    {

                        Console.Clear();
                        Console.WriteLine("Usuario: {0}", NombreUsuario);

                        Console.Write(" Confirme su contraeña: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        VerificarContraseña = Console.ReadLine();
                        Console.ResetColor();
                        if (VerificarContraseña.Equals(Contraseña))
                        {
                            
                            
                            ArchivoRegistrar.Close();
                            Console.ReadKey();
                            Console.ResetColor();

                        }
                        else
                        {
                            Console.ResetColor();
                            Console.Write(" Las contraseñas no coinciden");
                            Console.Clear();
                            Console.ReadKey();

                        }


                    }

                    break;

                case 2:
                    //Salir
                    Console.Clear();
                    Console.WriteLine("Presione <Enter> para salir");
                    Console.ReadKey();

                    break;

            }

        }


    }
}
