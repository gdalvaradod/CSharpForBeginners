public class Program
{
    public static void Main(string[] args){
        string PN ;
        string SN ;
        string APP ;
        string APM ;
        string DN;
        string MN;
        string An;
        string g;
        string ent;
        string PCP;
        string PCM;
        string PCN;
        int n1;
       char n2;
        Console.WriteLine("Por favor ingresa todos tus datos en mayusculas");
        Console.WriteLine("Ingrese el primer nombre");
        PN = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo nombre (en caso de que tenga)");
        SN = Console.ReadLine();
        Console.WriteLine("Ingrese el primer apellido/paterno");
        APP = Console.ReadLine();
        Console.WriteLine("Ingrse el segundo apellido/Materno");
        APM = Console.ReadLine();
        Console.WriteLine("Ingrese el dia de nacimiento(en digitos)");
        DN = Console.ReadLine();
        Console.WriteLine("Ingrese el mes de nacimiento (en digitos)");
        MN = Console.ReadLine();
        Console.WriteLine("Ingrese el año de nacimiento");
        An = Console.ReadLine();
        Console.WriteLine("Ingrese el genero H(Hombre) M(Mujer) X(No binario)");
        g = Console.ReadLine();
        Console.WriteLine("Ingrese la entidad federativa ");
        Console.WriteLine("========================================");
        Console.WriteLine("Aguascalientes = AS");
        Console.WriteLine("Baja California = BC");
        Console.WriteLine("Baja California Sur = BS");
        Console.WriteLine("Campeche = CC");
        Console.WriteLine("Coahuila de Zaragoza = CL");
        Console.WriteLine("Colima = CM");
        Console.WriteLine("Chiapas = CS");
        Console.WriteLine("Chihuahua = CH");
        Console.WriteLine("Distrito Federal = DF");
        Console.WriteLine("Durango = DG");
        Console.WriteLine("Guanajuato = GT");
        Console.WriteLine("Guerrero = GR");
        Console.WriteLine("Hidalgo = HG");
        Console.WriteLine("Jalisco = JC");
        Console.WriteLine("México = MC");
        Console.WriteLine("Michoacán de Ocampo = MN");
        Console.WriteLine("Morelos = MS");
        Console.WriteLine("Nayarit = NT");
        Console.WriteLine("Nuevo León = NL");
        Console.WriteLine("Oaxaca = OC");
        Console.WriteLine("Puebla = PL");
        Console.WriteLine("Queretaro = QT");
        Console.WriteLine("Quintana Roo = QR");
        Console.WriteLine("San Luis Potosí = SP");
        Console.WriteLine("Sinaloa = SL");
        Console.WriteLine("Sonora = SR");
        Console.WriteLine("Tabaco = TC");
        Console.WriteLine("Tamaulipas = TS");
        Console.WriteLine("Tlaxcala = TL");
        Console.WriteLine("Veracruz de Ignacio de la Llave = VZ");
        Console.WriteLine("Yucatán = YN");
        Console.WriteLine("Zacatecas = Zs");
        Console.WriteLine("Nacido en el Extranjero = NE");
        Console.WriteLine("Aqui tiene una lista en caso de que necesite ayuda (Solo ingrese las iniciales)");
        ent = Console.ReadLine();
        char CN = '\0'; 
        bool PPF = false;
        foreach (char letra in APP)
        {
            if (!PPF)
            {
                PPF = true;
                continue; 
            }
            if (char.IsLetter(letra) && !"AEIOUaeiou".Contains(letra))
            {
                    CN = letra;
                    break; 
            }
        }
          char CN1 = '\0'; 
        bool PPF2 = false;
        foreach (char letra in APM)
        {
            if (!PPF2)
            {
                PPF2 = true;
                continue; 
            }
            if (char.IsLetter(letra) && !"AEIOUaeiou".Contains(letra))
            {
                    CN1 = letra;
                    break; 
            }
        }
        char CN2 = '\0'; 
        bool PPF3 = false;
        foreach (char letra in PN)
        {
            if (!PPF3)
            {
                PPF3 = true;
                continue; 
            }
            if (char.IsLetter(letra) && !"AEIOUaeiou".Contains(letra))
            {
                    CN2 = letra;
                    break; 
            }
        }
        Random num = new Random();
        n1 = num.Next(1,9);
        Random let = new Random();
        n2 = (char)(let.Next(65,90));
        String CURP;
        CURP = string.Concat(APP[0],APP[1],APM[0],PN[0],An[2],An[3],MN,DN,g,ent,CN,CN1,CN2,n2,n1);
        Console.WriteLine(CURP);
    }
}