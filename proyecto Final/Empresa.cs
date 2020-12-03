using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_Final
{
    class Empresa
    {
        private string empleados;
        private double salarios;

        public Empresa(string empleados, double salarios)
        {
            this.empleados = empleados;
            this.salarios = salarios;
        }

        public string Empleados
        {
            get
            {
                return empleados;
            }
            set
            {
                empleados = value;
            }
        }


        public double Salarios
        {
            get
            {
                return salarios;
            }
            set
            {
                salarios = value;
            }
        }








    }
}
