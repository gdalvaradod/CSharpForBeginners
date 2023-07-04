namespace nBanco;

public class Banco 
{
    public string Nip { get; }
    public string NombreUsuario { get; }
    public string Clave = "12345SA5667";
    public string Balance { get; }

    public string HacerDeposito(int monto, string cuenta)
    {
        string mensaje = "¡Depósito realizado! \nCuenta: " + cuenta + "\nMonto: $" + monto;
        return mensaje;
    }

}