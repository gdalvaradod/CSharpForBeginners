Console.WriteLine("Bienvenido a mi calculadora");

// Solicitamos los números
Console.WriteLine("Introduce el primer número");
var a = Console.ReadLine();
Console.WriteLine("Introduce el segundo número");
var b = Console.ReadLine();

// Menú
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicación");
Console.WriteLine("4. División");
Console.WriteLine("===============================");

// Solicitamos la operación a realizar
Console.WriteLine("¿Qué operación quieres realizar?");
var opcion = Console.ReadLine();

// Variable de resultado
double resultado = 0.0;

// Lógica del menú
switch(Int32.Parse(opcion)){
    case 1: // Suma
        resultado = (double) Int32.Parse(a) + Int32.Parse(b);
        Console.WriteLine(a + " + " + b + " = " + resultado);
        break;
    case 2: // Resta
        resultado = (double) Int32.Parse(a) - Int32.Parse(b);
        Console.WriteLine(a + " - " + b + " = " + resultado);
        break;
    case 3: // Multiplicación
        resultado = (double) Int32.Parse(a) * Int32.Parse(b);
        Console.WriteLine(a + " X " + b + " = " + resultado);
        break;
    case 4: // División
        resultado = (double) Int32.Parse(a) / Int32.Parse(b);
        //double resultado = Convert.toDouble(a) / Convert.toDouble(b);
        Console.WriteLine(a + " / " + b + " = " + resultado);
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}
