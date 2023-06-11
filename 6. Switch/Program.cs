/*
Este ejercicio está disponible en la documentación oficial:
https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/statements/selection-statements
*/

Console.WriteLine("Introduce el número del día");
var dia = Console.ReadLine();
switch (Int32.Parse(dia)) 
{
  case 1:
    Console.WriteLine("Lunes");
    break;
  case 2:
    Console.WriteLine("Martes");
    break;
  case 3:
    Console.WriteLine("Miércoles");
    break;
  case 4:
    Console.WriteLine("Jueves");
    break;
  case 5:
    Console.WriteLine("Viernes");
    break;
  case 6:
    Console.WriteLine("Sábado");
    break;
  case 7:
    Console.WriteLine("Domingo");
    break;
}