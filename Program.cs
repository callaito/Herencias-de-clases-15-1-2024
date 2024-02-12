// See https://aka.ms/new-console-template for more information
using Herencias_de_clases_15_1_2024;

Console.WriteLine("Hello, World!");

string nombre, direccion, correo, carrera, asignatura;


    // Instanciar la clase Estudiante y obtener datos por teclado
    Estudiante Estudiante = new Estudiante();
    Console.WriteLine("Ingrese datos del estudiante:");
    Console.Write("Nombre: ");
    Estudiante.nombre = Console.ReadLine();
    Console.Write("Dirección: ");
    Estudiante.direccion = Console.ReadLine();
    Console.Write("Correo: ");
    Estudiante.correo = Console.ReadLine();
    Console.Write("Carrera: ");
    Estudiante.carrera = Console.ReadLine();

    // Instanciar la clase Profesor y obtener datos por teclado
    Profesor Profesor = new Profesor();
    Console.WriteLine("\nIngrese datos del profesor:");
    Console.Write("Nombre: ");
    Profesor.nombre = Console.ReadLine();
    Console.Write("Dirección: ");
    Profesor.direccion = Console.ReadLine();
    Console.Write("Correo: ");
    Profesor.correo = Console.ReadLine();
    Console.Write("Asignatura: ");
    Profesor.asignatura = Console.ReadLine();

Console.WriteLine();
    // Imprimir datos de Estudiante y Profesor
    Console.WriteLine("Datos del estudiante:");
    Estudiante.ImprimirDatos();
Console.WriteLine();
Console.WriteLine("Datos del profesor:");
    Profesor.ImprimirDatos();




