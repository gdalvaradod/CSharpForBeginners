using ClaseSaludo;
public class Program
{
    public static void Main(string[] args)
    {
        // Método con argunmentos obligatorios y opcionales
        void Saludo(string nombre, string apellidoPaterno, string SegundoNombre, string apellidoMaterno = "Leon", int edad = 25){
            Console.WriteLine("Hola " + nombre + " " + apellidoMaterno);
        }

        // Acceso a clase con método sobrecargado
        var MiClase = new Saludo(); // Instancia a la clase
        
        MiClase.Despedida("Adrian", "Lopez");

    }
}