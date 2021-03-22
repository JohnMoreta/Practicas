using System;

namespace Practica1
{
    public class Persona
    {
        protected long cedula;
        protected string nombre;
        protected string apellido;
        protected int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public string Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }
        }
        public long Cedula
        {
            set
            {
                cedula = value;
            }
            get
            {
                return cedula;
            }
        }

        public void Responsabilidad()
        {
            Console.WriteLine("Cedula:" + Cedula);
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Apellido:" + Apellido);
            Console.WriteLine("Edad:" + Edad);
        }
    }

    public class Profesor : Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        new public void Responsabilidad()
        {
            base.Responsabilidad();
            Console.WriteLine("Sueldo:" + Sueldo);
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            per.Cedula = 40215397163; 
            per.Nombre = "John";
            per.Apellido = "Moreta";
            per.Edad = 19;
            Console.WriteLine("Los Datos de la persona son:");
            per.Responsabilidad();

            Profesor emple = new Profesor();
            emple.Cedula = 00187594031;
            emple.Nombre = "Maria";
            emple.Apellido = "Del Carmen";
            emple.Edad = 35;
            emple.Sueldo = 7000;
            Console.WriteLine("Los Datos del Empleado son:");
            emple.Responsabilidad();

            Console.ReadKey();
        }
    }
}