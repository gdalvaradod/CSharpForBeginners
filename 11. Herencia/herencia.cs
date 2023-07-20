namespace herenciaClass;

public class Operacion // Clase padre
{
    // Se obtuvo de una BD
    protected int valor1; 
    protected int valor2;
    protected int resultado;

    // Constructores
    public int Valor1 { set { valor1 = value; } get { return valor1; } }
    public int Valor2 { set { valor2 = value; } get { return valor2; } }
    public int Resultado { set { resultado = value; } get { return resultado; } }
}

public class Suma: Operacion // Herencia
{
    public void Operar()
    {
        Resultado = Valor1 + Valor2; 
    }
}

public class Resta: Operacion // Herencia
{
    public void Operar()
    {
        Resultado = Valor1 - Valor2;
    }
}
