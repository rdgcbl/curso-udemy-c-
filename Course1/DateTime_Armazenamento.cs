/*

            DateTime d1 = DateTime.Now;         // PEGA O HORARIO ATUAL DO SISTEMA  
            DateTime b1 = DateTime.AddDay(7);   // ESTOU ADIANDO MAIS 7 DIAS, APARTIR DO HORARIO ATUAL
            DateTime d2 = DateTime.Today;       // GERA UMA DATA DE HOJE MAIS SEM HORARIO
            DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 58, 275);  //ANO, MES, DIA, HORA, MINUTO, SEGUNDO, MILISSEGUNDO          

            DateTime d5 = DateTime.Parse("2000-08-15");
            DateTime d6 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d7 = DateTime.Parse("15/08/2000");
            DateTime d8 = DateTime.Parse("15/08/2000 13:05:58");

            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d10 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);


        }

    }
}

=============================================================================

using System;

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);                 // DATA
            Console.WriteLine("2) Day: " + d.Day);                   // DIA
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);       // DIA DA SEMANA
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);       // DIA DO ANO
            Console.WriteLine("5) Hour: " + d.Hour);                 // HORA
            Console.WriteLine("6) Kind: " + d.Kind);                 // TIPO, SE É LOCAL OU UNIVERSAL
            Console.WriteLine("7) Millisecond: " + d.Millisecond);   // MILISEGUNDOS 
            Console.WriteLine("8) Minute: " + d.Minute);             // MINUTO
            Console.WriteLine("9) Month: " + d.Month);               // MES
            Console.WriteLine("10) Second: " + d.Second);            // SEGUNDO
            Console.WriteLine("11) Ticks: " + d.Ticks);              // QUANTIDADE DE TICK
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);      // É UM TIMESPAN UMA DURACAO
            Console.WriteLine("13) Year: " + d.Year);                // ANO
            Console.WriteLine();

            //============================================================================================
            //Formatação(DateTime-> string)                
            string s1 = d.ToLongDateString();   // FORMATO PARA IMPRIMIR A DATA DE UMA FORMA LONGA
            string s2 = d.ToLongTimeString();   // IMPRIMIU O HORARIO
            string s3 = d.ToShortDateString();  // IMPRIMIU A DATA NO FORMATO RESUMIDO
            string s4 = d.ToShortTimeString();  // IMPRIMI A HORA SEM O SEGUNDO
            string s5 = d.ToString();           // DATA NO FORMATO PADRÃO
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");       // FORMATAR MANUALMENTE A MINHA DATA DO GEITO QUE EU QUISER
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");   // SOH ADICIONOU OS MILISSEGUNDOS
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

           
=================================================================================

            
            DateTime d1 = DateTime.Parse("200-08-15 13:05:58");
            Console.WriteLine("d1: " +d1);
            Console.WriteLine("d1 Kind "+ d1.Kind);
            Console.WriteLine("d1 to Local: " +d1.ToLocalTime());
            


    
        }

    }
}*/