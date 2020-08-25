using Curso.ExerciciosLogica;
using Curso.TestPipeline;
using System;
using System.Diagnostics;

namespace Curso
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
        Exercicio1 ex = new Exercicio1();        
        ex.Soma();

        SaidaDeDados saida = new SaidaDeDados();
            stopwatch.Start();
            saida.EscreveTextoExercicio();
            stopwatch.Stop();


            Console.WriteLine($"Executado em {stopwatch.ElapsedMilliseconds} milisegundos");
           //test//
            int a = 6;
            a *= 2;
            Console.WriteLine("Atribuição " + a );
            //fim test//

            Console.WriteLine("-----------------------------------------aula 23-------------------------------------------------");
            EntradaDeDados entradaDeDados = new EntradaDeDados();
            entradaDeDados.LerInfoUsuario();

            //MembersPipe mp = new MembersPipe();

            //    mp.DownloadString();
            //    mp.CreatWordList();
            //    mp.FilterWordList();
            //    mp.FindReverseWord();
            //    mp.Print();


        }
    }
}
 