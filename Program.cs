using System;

namespace C_tp7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int sumador=0;
            int alumnos =0;
            int nota =0;
            float promedio=0f;
            string turno,nombre;
            //Entradas
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bienvenido al sistema de calificaciones de alumnos");
            Console.WriteLine("///////Por favor ingrese el nombre del curso//////");
            nombre=Console.ReadLine();
            Console.WriteLine("Por favor ingrese el turno del curso");
            turno=Console.ReadLine();
            Console.WriteLine("Por favor ingrese cuantos alumnos hay en el curso ");
            alumnos=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //Operacion con if
            for(int contador=1;contador<=alumnos;contador=contador+1){
                Console.WriteLine("Por favor Ingrese la nota de un alumno");
                nota=Convert.ToInt32(Console.ReadLine());
                sumador = sumador+nota;
            }
            promedio=((float)sumador/(float)alumnos);
            Console.Clear();
            //Salida
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("******************************************************************");
            Console.WriteLine("La nota promedio del curso "+nombre+" turno "+turno+" es "+promedio);
            Console.WriteLine("******************************************************************");            

        }
    }
}
