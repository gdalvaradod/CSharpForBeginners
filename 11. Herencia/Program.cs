using herenciaClass;
class Program
{
    public static void Main(string[] args)
    {
        // Instancia
        Suma miSuma = new Suma();
        miSuma.Valor1 = 10;
        miSuma.Valor2 = 5;
        miSuma.Operar(); // Aquí hago la suma
        Console.WriteLine("El resultado de mi suma es: " + miSuma.Resultado);

        // Resta
    }
}