using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.src.exercicios2_estrutura_condicional
{
    public class exercicio1_estrutura_condicional
    {
        public void ImparOuPar()
        {
            double number;
            string resul = "";
            Console.WriteLine("Saiba se o numero é par ou impar");
            number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
                resul = "Par";
            else
                resul = "Impar";

            Console.WriteLine($"Seu numero é {resul}");
        }
    }
}
