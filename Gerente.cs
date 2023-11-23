using System;
    
namespace GestionEmpleados {
    internal class Gerente : Empleado, IMostrarInformacion {
        // Atributos
        private string departamento;

        // Metodos
        public string Departamento { 
            get { return departamento; } 
            set { departamento = value; }
        }

        // Constructor, usamos la palabra reservada base para llamar al constructor del empleado
        public Gerente(string nombre, double salario, string departamento) : base(nombre, salario) {
            Departamento = departamento;
        }

        // Funcion de la interfaz, con la palabra base llamamos al MostrarInformacion y añadimos el Departamento
        public new void MostrarInformacion() {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }
}
