using System;
using System.Linq;
using System.Text;

namespace proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {


            Empresa[] personalArray = new Empresa[5];
            personalArray[0] = new Empresa("José Contreras", 25000);
            personalArray[1] = new Empresa("Lizandra Ramírez", 35000);
            personalArray[2] = new Empresa("Luis Rodriguez", 22000);
            personalArray[3] = new Empresa("Ryan Brandon", 38000);
            personalArray[4] = new Empresa("Noelia Mendes", 41000);
            string nom = personalArray[0].Empleados;
            double suma = 0;
            double mult = 0;
            double may = 0;

            Console.WriteLine("Información sobre empleados:\n");

            for (int e = 0; e < personalArray.Length; e++) //Parte A
            {

                Console.WriteLine("{0}, {1}", personalArray[e].Empleados, personalArray[e].Salarios);

            }


            for (int e = 0; e < personalArray.Length; e++) //Parte B
            {
                mult = 3 * personalArray[e].Salarios;
                Console.WriteLine($"\nEl ingreso de salario de " +
                    $"{personalArray[e].Empleados} por los ultimos 3 meses es: {+mult}");

            }


            for (int e = 0; e < personalArray.Length; e++) //Parte C
            {
                suma = suma + personalArray[e].Salarios;
            }

            double total = suma * 3;
            Console.WriteLine("\nEl total pagado en salario a todos los empleados en los últimos 3 meses es: " + total);



            for (int e = 0; e < personalArray.Length; e++) //Parte D
            {
                mult = 3 * personalArray[e].Salarios;

                if (mult > may)
                {
                    may = personalArray[e].Salarios;
                    nom = personalArray[e].Empleados;

                }

            }

            Console.WriteLine($"\nEl empleado con mayor ingreso acumulado es:  {nom} ");



        }

    }


}
