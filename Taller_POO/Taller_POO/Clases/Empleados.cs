using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO.Clases
{
   
    public abstract class Empleado
    {
        private int id;
        private string nombre;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Empleado(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public abstract decimal CalcularSalario();

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombre: " + nombre);
        }
    }

    public class EmpleadoTiempoCompleto : Empleado
    {
        private decimal salarioFijo;

        public EmpleadoTiempoCompleto(int id, string nombre, decimal salarioFijo)
            : base(id, nombre)
        {
            this.salarioFijo = salarioFijo;
        }

        public override decimal CalcularSalario()
        {
            return salarioFijo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Tiempo Completo");
            Console.WriteLine("Salario: " + CalcularSalario());
            Console.WriteLine("--------------------");
        }
    }

        public class EmpleadoPorHoras : Empleado
        {
            private int horasTrabajadas;
            private decimal valorPorHora;

            public EmpleadoPorHoras(int id, string nombre, int horasTrabajadas, decimal valorPorHora)
                : base(id, nombre)
            {
                this.horasTrabajadas = horasTrabajadas;
                this.valorPorHora = valorPorHora;
            }

            public override decimal CalcularSalario()
            {
                return horasTrabajadas * valorPorHora;
            }

            // Sobrecarga
            public decimal CalcularSalario(int horasExtra)
            {
                return (horasTrabajadas + horasExtra) * valorPorHora;
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine("Tipo: Por Horas");
                Console.WriteLine("Salario: " + CalcularSalario());
                Console.WriteLine("--------------------");
            }
        }
}
    

