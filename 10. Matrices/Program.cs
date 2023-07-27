using MatrizClass;

Console.WriteLine("Ingresa el número de filas");
var fila = Console.ReadLine();
Console.WriteLine("Ingresa el número de columnas");
var columna = Console.ReadLine();

Matriz2 ma = new Matriz2();
ma.Ingresar(Int32.Parse(fila), Int32.Parse(columna));
ma.Imprimir(Int32.Parse(fila), Int32.Parse(columna));