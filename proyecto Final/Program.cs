using System;
using System.Linq;
using System.Text;

namespace proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado infoEmpls = new Empleado();
            Empleado nombre1 = new Empleado();
            Empleado nombre2 = new Empleado();
            Empleado nombre3 = new Empleado();
            Empleado nombre4 = new Empleado();
            Empleado nombre5 = new Empleado();

            //Empleado nombre1, nombre2, nombre3, nombre4 , nombre5 = new Empleado(); BORRAR


            Empleado salario01 = new Empleado();
            Empleado salario02 = new Empleado();
            Empleado salario03 = new Empleado();
            Empleado salario04 = new Empleado();
            Empleado salario05 = new Empleado();
            Empleado salariototal = new Empleado();

            Empleado mayorsalario = new Empleado();
            mayorsalario.empleadoMayorSueldo();
            Console.WriteLine(mayorsalario);
           // double sal = salariototal.operacion();
            //Console.WriteLine(nombre1);
            //Console.WriteLine("El total del salario de todos los empleados en los ultimos tres meses es de: " + sal);


          //  infoEmpls.getInfo();
            //Console.WriteLine(infoEmpls.getInfo());

        }
    }

    class Empleado
    {
        string nombreEmpl1;
        string nombreEmpl2;
        string nombreEmpl3;
        string nombreEmpl4;
        string nombreEmpl5;

        double salario1;
        double salario2;
        double salario3;
        double salario4;
        double salario5;



        private string[] empleados = { "José Contreras", "Lizandra Ramírez", "Luis Rodriguez", "Ryan Brandon", "Noelia Mendes" };
        private double[] salarios = { 25000, 32000, 22000, 41000, 38000 };

        // Console.WriteLine();


        public Empleado()
        {
            nombreEmpl1 = "José Contreras";
            nombreEmpl2 = "Lizandra Ramírez";
            nombreEmpl3 = "Luis Rodriguez";
            nombreEmpl4 = "Ryan Brandon";
            nombreEmpl5 = "Noelia Mendes";

            salario1 = 25000;
            salario2 = 352000;
            salario3 = 22000;
            salario4 = 41000;
            salario5 = 38000;
        }


        public double operacion()
        {
            //total pagado de todos los empleados en los ultimos 3 meses.

            double[] salariototal = { salario1, salario2, salario3, salario4, salario5 };

            double suma = salariototal.Sum();
            double total = suma * 3;
            return total;

        }


        public string getInfo()
        {
            return "\nInformación sobre los empleados:\n" + "\nEmpleado 1: " + "\nNombre: " + nombreEmpl1 + "\nSalario: " + salario1 +
                    "\n\nEmpleado 2: " + "\nNombre: " + nombreEmpl2 + "\nSalario: " + salario2 +
                    "\n\nEmpleado 3: " + "\nNombre: " + nombreEmpl3 + "\nSalario: " + salario3 +
                    "\n\nEmpleado 4: " + "\nNombre: " + nombreEmpl4 + "\nSalario: " + salario4 +
                    "\n\nEmpleado 5: " + "\nNombre: " + nombreEmpl5 + "\nSalario: " + salario5;

            //TODO 
        }


        public void empleadoMayorSueldo()
        {

            double mayor = 0;

            string nom;

            nom = empleados[0];

            for (int i = 0; i > salarios.Length; i++)
            {
                Console.WriteLine(salarios[0]);

                if (salarios[i] > mayor)
                {
                    mayor = salarios[i];
                    nom = empleados[i];

                    Console.WriteLine("El empleado con mayor salario es: " + nom + " que tiene un salario de: " + mayor);

                }



            }


        }
    }


}
