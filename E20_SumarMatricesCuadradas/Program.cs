using System;

namespace E20_SumarMatricesCuadradas
{
    //20.- dadas dos matrices cuadradas A y B imprimir la suma de ellas
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[,] A = ObtenerMatrizCuadradaConAleatorios(10, 99, size);
            int[,] B = ObtenerMatrizCuadradaConAleatorios(10, 99, size);

            Console.WriteLine("Las matrices son:");
            for( int i=0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("[{0}] ", A[i, j]);
                Console.WriteLine();
            }
                
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("[{0}] ", B[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("\nLa suma de las matrices es:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("[{0}] ", (A[i,j]+B[i, j]));
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public static int[,] ObtenerMatrizCuadradaConAleatorios(int min, int max, int size)
        {
            Random random = new Random();
            int[,] resultado = null;

            if (size > 0 && min < max)
            {
                resultado = new int[ size, size ];
                for (int i = 0; i < size; i++)                
                    for (int j = 0; j < size; j++)
                        resultado[ i, j ] = random.Next(min, max);
            }

            return resultado;
        }
    }
}
