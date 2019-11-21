using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            string Usuario, Contraseña, DatosIniciar;
            int Intentos = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Inicio de sesión");
                Console.Write("\nUsuario: ");
                Usuario = Console.ReadLine();

                Console.Write("\nContraseña: ");
                Console.ForegroundColor = ConsoleColor.Black;
                Contraseña = Console.ReadLine();
                DatosIniciar = Usuario + ":" + Contraseña;
                Console.ResetColor();
                if (Validar(DatosIniciar) == true)
                {
                    Console.WriteLine("Ingresado correctamente");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    Intentos++;
                }

            } while (Intentos != 3);
            if (Intentos == 3)
            {

                Console.WriteLine("El sistema fue bloqueado");
                Console.ReadLine();
            }


        }

        static bool Validar(string Contra)
        {
            string DatosUsuario;
            bool UsuarioCorrecto = false;
            StreamReader Archivo = new StreamReader("Usuarios.txt");
            do
            {
                DatosUsuario = Archivo.ReadLine();
                if (DatosUsuario == Contra)
                {
                    UsuarioCorrecto = true;
                }

            } while (DatosUsuario != null);
            return UsuarioCorrecto;
        }

    }
}
