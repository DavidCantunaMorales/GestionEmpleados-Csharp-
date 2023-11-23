using System;

namespace GestionEmpleados {
    // Implementacion de la Interfaz IMostrarInformacion
    internal class Empleado : IMostrarInformacion {
        // Atributos
        private string nombre;
        private double salario;

        // Constructor
        public Empleado(string nombre, double salario) {
            Nombre = nombre;
            Salario = salario;
        }

        // Metodos
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Salario {
            get { return salario; }
            set { salario = value; }
        }

        // Metodo para calcular el salario
        public double CalcularSalarioAnual() {
            return Salario * 12;
        }

        // Implementacion de la funcion de la interfaz
        public void MostrarInformacion() {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario Mensual: ${Salario}");
            Console.WriteLine($"Salario Anual: ${CalcularSalarioAnual()}");
        }
    }
}