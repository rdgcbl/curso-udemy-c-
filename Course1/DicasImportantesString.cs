/*
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course1 {
    class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper();             // FAZ TUDO FICAR MAIUSCULO
            string s2 = original.ToLower();             // FAZ TUDOS FICAR MINUSCULO
            string s3 = original.Trim();                // APAGA TODOS OS ESPAÇOS
            string s4 = original.Substring(3);          // INDICE QUE QUER CORTAR (APARTIR DA TERCEIRA LETRA ELE VAI CORTAR)
            string s5 = original.Substring(3, 5);       // COMECA NO 3 E CORTA 5 LETRAS ESPACO ETC..
            string s6 = original.Replace('a', 'x');     // TROCA TODO CARACTER 'A' PELO 'X'
            string s7 = original.Replace("abc", "xy");  // TROCA TODOS CARACTER 'ABC' PELO 'XY'

            bool b1 = String.IsNullOrEmpty(original);      // TESTA SE A VARIAVEL É NULO(NULL) OU VAZIO("")
            bool b2 = String.IsNullOrWhiteSpace(original); // TESTA SE A VARIAVEL É NULA OU ESPACO EM BRANCO

            int n1 = original.IndexOf("bc");        // CONTA A POSICAO DAS LETRAS ORDEM CRESCENTE 
            int n2 = original.LastIndexOf("bc");    // CONTA A POSICAO DAS LETRAS ORDEM DECRESCENTE

            //.Split(' ')  //Recortar um espaco
            //.ToString("f2",CultureInfo.............)

            Console.WriteLine("Original :          -" + original + "-");
            Console.WriteLine("ToUpper  :          -" + s1 + "-");
            Console.WriteLine("ToLoweer :          -" + s2 + "-");
            Console.WriteLine("Trim     :          -" + s3 + "-");
            Console.WriteLine("IndexOf('bc')       -" + n1);
            Console.WriteLine("LastIndexOf('bc')   -" + n2);
            Console.WriteLine("Substring:(3)       -" + s4 + "-");
            Console.WriteLine("Substring:(3, 5)    -" + s5 + "-");
            Console.WriteLine("Replace:(a , x)     -" + s6 + "-");
            Console.WriteLine("Replace:(abc , xy)  -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty:      -" + b1);
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2);


        }
    }
}
*/