/*
Crear una función que regrese el número mayor de un array / lista
*/
internal class Program
{
    public static void Main(string[] args) // Función principal - Ejecución principal
    {
        int[] listNumero = {5,6,7,12,2,8,9};
        Console.WriteLine("El número mayor de la lista es:");
        Console.WriteLine(NumeroMayorArray(listNumero)); // Invocación de la función ¿?
    }

    public static int NumeroMayorArray(int[] array) // Nuestra función
    {
        // Valido que mi lista o arreglo no están vacías
        if(array != null && array.Length > 0){

            int final = array[0]; // |9| Variable de almacenamiento inicializada
            
            for(int i = 0; i < array.Length; i++){ // Ciclo que determina el número de vueltas a dar
                if(array[i] > final){ // Valida la posición actual contra el contenido de la variable final
                    final = array[i]; // En caso de ser mayor, reemplaza el valor de la variable final
                }
            }

            return final; // Regreso el número mayor de la lista 

        }
        else
        {
            Console.WriteLine("Tu lista está vacía");
            return 00; // Este return sólo es en caso de error
        }
    }
}