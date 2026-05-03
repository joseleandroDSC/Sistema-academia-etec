using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();

        while (true)
        {
            Console.WriteLine("\n1 - Cadastrar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("0 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Aluno aluno = new Aluno();

                Console.Write("Nome: ");
                aluno.nome = Console.ReadLine();

                Console.Write("Idade: ");
                aluno.idade = int.Parse(Console.ReadLine());

                alunos.Add(aluno);
            }
            else if (opcao == 2)
            {
                foreach (Aluno a in alunos)
                {
                    Console.WriteLine($"Nome: {a.nome} - Idade: {a.idade}");
                }
            }
            else if (opcao == 0)
            {
                break;
            }
        }
    }
}