using Curso.TestPipeline;
using System;

namespace Curso
{
    public class Program
    {
        static void Main(string[] args)
        {       
        Exercicio1 ex = new Exercicio1();        
        ex.Soma();

        MembersPipe mp = new MembersPipe();

            mp.DownloadString();
            mp.CreatWordList();
            mp.FilterWordList();
            mp.FindReverseWord();
            mp.Print();
          
        }
    }
}
 