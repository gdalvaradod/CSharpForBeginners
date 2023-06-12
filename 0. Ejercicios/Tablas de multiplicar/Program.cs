Console.WriteLine("¿Qué tabla de multiplicar quieres imprimir?");
var tabla = Console.ReadLine();
int result = 0;

switch(Int32.Parse(tabla)){
    case 1:
        for(int i = 1; i <= 10; i++){
            result = Int32.Parse(tabla) * i;
            Console.WriteLine(Int32.Parse(tabla) + " X " + i + " = " + result);
        }
        break;

    case 2:
        for(int i = 1; i <= 10; i++){
            result = Int32.Parse(tabla) * i;
            Console.WriteLine(Int32.Parse(tabla) + " X " + i + " = " + result);
        }
        break;

    case 3:
        for(int i = 1; i <= 10; i++){
            result = Int32.Parse(tabla) * i;
            Console.WriteLine(Int32.Parse(tabla) + " X " + i + " = " + result);
        }
        break;

    case 4:
        for(int i = 1; i <= 10; i++){
            result = Int32.Parse(tabla) * i;
            Console.WriteLine(Int32.Parse(tabla) + " X " + i + " = " + result);
        }
        break;

    case 5:
        for(int i = 1; i <= 10; i++){
            result = Int32.Parse(tabla) * i;
            Console.WriteLine(Int32.Parse(tabla) + " X " + i + " = " + result);
        }
        break;

    case 6:
        for(int i = 1; i <= 10; i++){
            result = Int32.Parse(tabla) * i;
            Console.WriteLine(Int32.Parse(tabla) + " X " + i + " = " + result);
        }
        break;

    case 7:
        for(int i = 1; i <= 10; i++){
            result = Int32.Parse(tabla) * i;
            Console.WriteLine(Int32.Parse(tabla) + " X " + i + " = " + result);
        }
        break;

    case 8:
        for(int i = 1; i <= 10; i++){
            result = Int32.Parse(tabla) * i;
            Console.WriteLine(Int32.Parse(tabla) + " X " + i + " = " + result);
        }
        break;

    case 9:
        for(int i = 1; i <= 10; i++){
            result = Int32.Parse(tabla) * i;
            Console.WriteLine(Int32.Parse(tabla) + " X " + i + " = " + result);
        }
        break;

    default:
        Console.WriteLine("No entiendo tu respuesta");
        break;
}