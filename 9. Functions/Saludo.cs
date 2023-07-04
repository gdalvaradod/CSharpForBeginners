namespace ClaseSaludo;

public class Saludo 
{

    // Propiedades de la clase
    public string alumno = "Adrian";
    private string maestro = "Geovanny";

    // Método sobrecargado
    public void Despedida(string nombre){
        Console.WriteLine("Adiós a todos");
    }

    public void Despedida(string nombre, string apellido){
        Console.WriteLine("Adiós, " + nombre);
    }

}