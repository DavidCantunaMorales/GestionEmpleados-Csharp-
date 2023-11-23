using System;

namespace GestionEmpleados {
    class Program {
        static void Main() {
            // Crear una instancia de Empleado
            Empleado emp = new Empleado("David", 420);

            // Mostrar información del Empleado
            Console.WriteLine("Información del Empleado:");
            emp.MostrarInformacion();
            Console.WriteLine();

            // Crear una instancia de Gerente
            Gerente grt = new Gerente("Martha", 1000, "Desarollo Web");

            // Mostrar información del Gerente
            Console.WriteLine("Información del Gerente:");
            grt.MostrarInformacion();
        }
    }
}
