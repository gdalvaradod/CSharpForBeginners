List<int> MisNumeros = new List<int>(); // Lista de enteros o números
// Agregar elementos a nuestra listaa
MisNumeros.Add(1);
MisNumeros.Add(2);
MisNumeros.Add(3);
MisNumeros.Add(4);
MisNumeros.Add(5);

/*
Lista de manera lógica
[]  ---> [1,2,3,4,5]
[]  ---> [0,1,2,3,4]
*/

List<string> MisCompras = new List<string>(); // Lista de cadena o string
// Agregar elementos a nuestra listaa
MisCompras.Add("Huevos");
MisCompras.Add("Mantequilla");
MisCompras.Add("Aceite");
MisCompras.Add("Leche");
MisCompras.Add("Cereal");

var Alumnos = new List<string>()
{
    "Alejandro",
    "Luis",
    "Jimmer",
    "Mario",
    "Manuel"
};

Console.WriteLine("============================");
Console.WriteLine("Lista original");
Console.WriteLine("============================");
for(int i = 0; i < Alumnos.Count; i++){
    Console.WriteLine(i + ". " + Alumnos[i]);
}

Console.WriteLine("============================");
Console.WriteLine("Lista con valores nuevos");
Console.WriteLine("============================");
Alumnos.Add("Joshua");
Alumnos.Add("Alan");
for(int i = 0; i < Alumnos.Count; i++){
    Console.WriteLine(i + ". " + Alumnos[i]);
}

Console.WriteLine("============================");
Console.WriteLine("Lista con nombres removidos");
Console.WriteLine("============================");
Alumnos.RemoveAt(2);
Alumnos.RemoveAt(1);
for(int i = 0; i < Alumnos.Count; i++){
    Console.WriteLine(i + ". " + Alumnos[i]);
}