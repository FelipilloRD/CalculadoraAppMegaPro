// Tarea 1: Calculadora y Evaluador de Calificaciones
// Programacion 1

bool keepGoing = true;

while (keepGoing)
{
    // Menu principal
    Console.WriteLine("\n--- CALCULADORA ---");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Evaluacion de Estudiante (Aprobado / Reprobado)");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opcion (1-6): ");

    string? choice = Console.ReadLine();
    if (choice == null) break;

    // Si el usuario presiona Enter sin escribir nada, volvemos a mostrar el menu
    if (string.IsNullOrWhiteSpace(choice))
    {
        continue;
    }

    choice = choice.Trim().Trim('\uFEFF');
    switch (choice)
    {
        case "1":
            // Operacion de suma
            Console.Write("\nIngrese el primer numero: ");
            double add1 = ReadDouble();
            Console.Write("Ingrese el segundo numero: ");
            double add2 = ReadDouble();
            Console.WriteLine($"Resultado: {add1} + {add2} = {add1 + add2}");
            break;

        case "2":
            // Operacion de resta
            Console.Write("\nIngrese el primer numero: ");
            double sub1 = ReadDouble();
            Console.Write("Ingrese el segundo numero: ");
            double sub2 = ReadDouble();
            Console.WriteLine($"Resultado: {sub1} - {sub2} = {sub1 - sub2}");
            break;

        case "3":
            // Operacion de multiplicacion
            Console.Write("\nIngrese el primer numero: ");
            double mult1 = ReadDouble();
            Console.Write("Ingrese el segundo numero: ");
            double mult2 = ReadDouble();
            Console.WriteLine($"Resultado: {mult1} * {mult2} = {mult1 * mult2}");
            break;

        case "4":
            // Operacion de division con control de division entre cero
            Console.Write("\nIngrese el primer numero (dividendo): ");
            double div1 = ReadDouble();
            Console.Write("Ingrese el segundo numero (divisor): ");
            double div2 = ReadDouble();

            if (div2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
            else
            {
                Console.WriteLine($"Resultado: {div1} / {div2} = {div1 / div2}");
            }
            break;

        case "5":
            // Evaluacion de aprobacion del estudiante usando un array
            Console.Write("\nIngrese el nombre del estudiante: ");
            string studentName = Console.ReadLine() ?? "";

            Console.Write("¿Cuantas notas desea ingresar?: ");
            int totalGrades = 0;
            while (true)
            {
                string? input = Console.ReadLine();
                if (input == null) break;
                if (int.TryParse(input, out totalGrades) && totalGrades > 0)
                {
                    break;
                }
                Console.Write("Por favor ingrese un numero mayor a 0: ");
            }

            if (totalGrades <= 0) break;

            // Declaracion del array para almacenar las notas
            double[] grades = new double[totalGrades];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Ingrese la nota #{i + 1} (0-100): ");
                double grade = 0;
                while (true)
                {
                    string? input = Console.ReadLine();
                    if (input == null) break;
                    if (double.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                    {
                        break;
                    }
                    Console.Write("Nota invalida. Ingrese un numero entre 0 y 100: ");
                }
                grades[i] = grade;
            }

            // Calculo de la suma recorriendo el array con un bucle
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }

            double average = sum / grades.Length;
            Console.WriteLine($"\nEstudiante : {studentName}");
            Console.WriteLine($"Promedio   : {average:F2}");

            // Condicional para verificar si aprobo (minimo 70 puntos)
            if (average >= 70)
            {
                Console.WriteLine("Estado     : Aprobado");
            }
            else
            {
                Console.WriteLine("Estado     : Reprobado");
            }
            break;

        case "6":
            // Opcion para salir del programa
            keepGoing = false;
            Console.WriteLine("Saliendo del programa...");
            continue;

        default:
            Console.WriteLine("Opcion invalida. Intente nuevamente.");
            continue;
    }

    // Pregunta para repetir o cerrar el programa
    Console.Write("\n¿Desea realizar otra operacion? (s/n): ");
    string? response = Console.ReadLine();
    if (response == null) break;

    response = response.Trim().ToLower();
    if (response == "n" || response == "no")
    {
        keepGoing = false;
        Console.WriteLine("¡Hasta luego!");
    }
}

// Funcion para validar que el usuario ingrese un numero valido
double ReadDouble()
{
    while (true)
    {
        string? input = Console.ReadLine();
        if (input == null) return 0;
        if (double.TryParse(input, out double number))
        {
            return number;
        }
        Console.Write("Entrada invalida. Por favor ingrese un numero: ");
    }
}
