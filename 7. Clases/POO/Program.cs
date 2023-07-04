using nBanco;
class Program
{
    public static void Main(string[] args)
    {

        var banco = new Banco(); // Esta es la conexión a la clase

        string clave = banco.Clave;
        var Deposito = banco.HacerDeposito(200, "1234634535677");
        Console.WriteLine(Deposito);
    }
}