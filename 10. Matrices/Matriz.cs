namespace MatrizClass{
    class Matriz2{
        private int[,] mat;

        public void Ingresar(int fila, int columna)
        {
            mat = new int[fila, columna];
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    Console.Write("Ingrese posicion ["+(f+1)+","+(c+1)+"]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir(int fila, int columna)
        {
            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}