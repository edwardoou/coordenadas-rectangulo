using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int xA, yA, xB, yB, xC, yC, xD, yD;
                Console.WriteLine("INGRESO DE COORDENADAS");
                Console.WriteLine("Ingresar primera coordenada X:");
                xA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar primera coordenada Y:");
                yA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Primera Coordenada: ({xA},{yA})");
                Console.WriteLine("Ingresar segunda coordenada X:");
                xB = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar segunda coordenada Y:");
                yB = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Segunda Coordenada: ({xB},{yB})");
                Console.WriteLine("Ingresar tercera coordenada X:");
                xC = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar tercera coordenada Y:");
                yC = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Tercera Coordenada: ({xC},{yC})");
                Console.WriteLine("Ingresar tercera coordenada X:");
                xD = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar tercera coordenada Y:");
                yD = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Cuarda Coordenada: ({xD},{yD})");

                Persona persona = new Persona
                {
                    Nombres = "Alex Edwardo",
                    Apellidos = "Ramos Tito"
                };
                Rectangulo rectangulo = new Rectangulo();
                Punto puntoA = new Punto(xA, yA);
                Punto puntoB = new Punto(xB, yB);
                Punto puntoC = new Punto(xC, yC);
                Punto puntoD = new Punto(xD, yD);

                double perimetro = rectangulo.Perimetro(puntoA, puntoB, puntoC, puntoD);
                double area = rectangulo.Area(puntoA, puntoB, puntoC, puntoD);
                string alumno = persona.DevolverNombresCompletos();

                Console.WriteLine("");
                Console.WriteLine($"Alumno: {alumno}");
                Console.WriteLine($"El perimetro total es de: {perimetro} cm.");
                Console.WriteLine($"El area total es de: {area} cm.");
                //Crear una funcion que valide que los puntos ingresados forman un rectangulo
                Console.Read();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
