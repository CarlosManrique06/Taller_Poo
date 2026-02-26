using Taller_POO.Clases;

namespace Taller_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new EmpleadoTiempoCompleto(1, "Carlos", 3000000));
            empleados.Add(new EmpleadoPorHoras(2, "Miguel", 160, 20000));

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Agregar Empleado Tiempo Completo");
                Console.WriteLine("2. Agregar Empleado Por Horas");
                Console.WriteLine("3. Mostrar Todos los Empleados");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("ID: ");
                        int idTC = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombreTC = Console.ReadLine();

                        Console.Write("Salario fijo: ");
                        decimal salario = decimal.Parse(Console.ReadLine());

                        empleados.Add(new EmpleadoTiempoCompleto(idTC, nombreTC, salario));
                        Console.WriteLine("Empleado agregado correctamente.");
                        break;

                    case "2":
                        Console.Write("ID: ");
                        int idPH = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombrePH = Console.ReadLine();

                        Console.Write("Horas trabajadas: ");
                        int horas = int.Parse(Console.ReadLine());

                        Console.Write("Valor por hora: ");
                        decimal valorHora = decimal.Parse(Console.ReadLine());

                        empleados.Add(new EmpleadoPorHoras(idPH, nombrePH, horas, valorHora));
                        Console.WriteLine("Empleado agregado correctamente.");
                        break;

                    case "3":
                        Console.WriteLine("\n--- LISTA DE EMPLEADOS ---");
                        foreach (Empleado emp in empleados)
                        {
                            emp.MostrarInformacion();
                        }
                        break;

                    case "4":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
