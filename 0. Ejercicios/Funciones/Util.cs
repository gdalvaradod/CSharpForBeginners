namespace UtilClass;

public class Util
{
    public static void isVocal(char letra)
    {
        switch(letra)
        {
            case 'a':
                Console.WriteLine(letra + " Es vocal");
                break;
            case 'e':
                Console.WriteLine(letra + " Es vocal");
                break;
            case 'i':
                Console.WriteLine(letra + " Es vocal");
                break;
            case 'o':
                Console.WriteLine(letra + " Es vocal");
                break;
            case 'u':
                Console.WriteLine(letra + " Es vocal");
                break;
            default:
                Console.WriteLine("Es consonante");
                break;
        }
       
    }
}