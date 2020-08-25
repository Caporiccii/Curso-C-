using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.ExerciciosLogica
{
   public class EntradaDeDados
    {
        string nome;
        int quartos;
        double preço;
        string ultimoNome;
        string idade;
        string altura;
        string [] vetor;
        public void LerInfoUsuario()
        {

            Console.WriteLine("Entre com seu nome completo");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto custa esse produto?");
            preço = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu ultimo nome, idade e altura");
            vetor = Console.ReadLine().Split(' ');


            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Tem " +quartos+ " na sua casa.");
            Console.WriteLine("Produto custa R$ " + preço );
            Console.WriteLine($"Seu ultimo nome, idade e altura são {ultimoNome=vetor[0]}, {idade=vetor[1]}, {altura = vetor[2]} ");
            

        }

    }
}
