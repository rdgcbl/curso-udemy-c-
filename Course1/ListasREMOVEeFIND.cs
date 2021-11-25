/*using System;
using System.Collections.Generic;

namespace Course1 {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();


            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");


            foreach (string name in list) {
                Console.WriteLine(name);

            }
            Console.WriteLine();
            Console.WriteLine("Total na lista: " + list.Count); //count: pega o total

            string s1 = list.Find(x => x[0] == 'A'); //primeira ocorrencia de quem comeca com A
            Console.WriteLine("First 'A' : " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); //ultima ocorrencia de quem comeca com A
            Console.WriteLine("Last 'A' : " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); // primeira posicao que comeca com A
            Console.WriteLine("First position 'A' : " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A' : " + pos2); //ultima posicao que comeca com A

            List<string> list2 = list.FindAll(x => x.Length == 5);// encontrar todos que tenha tamanho string 5(5 letras)
            Console.WriteLine("-----------------------");

            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex"); //aqui esta removendo o alex apenas
            Console.WriteLine("-----------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); // aqui esta removendo todos que comecam com a letra 'M'
            Console.WriteLine("-----------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3); //aqui esta removendo o bob da lista 1, o foreach é só para testar se removeu msmo
            Console.WriteLine("-----------------------"); //estou removendo quem esta na posicao 3
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); //quero remover apartir da posicao 2, dois elementos
            Console.WriteLine("-----------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            




        }
    }
}*/