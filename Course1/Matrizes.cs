/*using System;
using System.Collections.Generic;
using System.Text;

namespace Course1 {
    class Matrizes {

        static void Main(string[] args) {

            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //quantos elementos a matriz tem no total

            Console.WriteLine(mat.Rank); //quantidade de linhas

            Console.WriteLine(mat.GetLength(0));// quer dizer a primeira dimensao [2, 3], no caso é 2

            Console.WriteLine(mat.GetLength(1));// quer dizer a segunda dimensao [2, 3], no caso o 3

        }

    }
}



using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course1 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
                Console.WriteLine("Main Diagonal:");
                for (int i = 0; i < n; i++) {
                    Console.Write(mat[i, i] + " ");
                }
                Console.WriteLine();

                int count = 0;
                for (int i = 0; i < n; i++) {           //comando para contar linhas
                    for (int j = 0; j < n; j++) {       //comando para contar colunas
                        if (mat[i, j] < 0) {
                            count++;
                        }
                    }
                }
                Console.WriteLine("Negative Numbers: " + count);
            
        }
    }
}

*/