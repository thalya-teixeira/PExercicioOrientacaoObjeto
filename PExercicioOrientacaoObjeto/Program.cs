using System;

namespace ProjExOrientacaoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] Pessoa = new String[3, 4];

            InserirDados();
            ImprimirDados();


            void InserirDados()
            {

                for (int lin = 0; lin < 3; lin++)//linha
                {
                    for (int col = 0; col < 4; col++)//coluna
                    {
                        if (col == 0)
                        {
                            Console.Write("\nInforme o " + (lin + 1) + "º nome: ");
                            Pessoa[lin, col] = Console.ReadLine();
                        }

                        else if (col == 1)
                        {
                            Console.Write("Informe a sua data de nascimento: ");
                            Pessoa[lin, col] = Console.ReadLine();
                        }

                        else if (col == 2)
                        {
                            Console.Write("Informe o seu CPF: ");
                            Pessoa[lin, col] = Console.ReadLine();

                        }

                        else if (col == 3)
                        {
                            Console.Write("Informe o seu telefone: ");
                            Pessoa[lin, col] = Console.ReadLine();
                        }
                    }
                }
            }

            void ImprimirDados()
            {
                Console.Write("\nDados da 1º Pessoa: ");
                Pessoa pessoa = new Pessoa(Pessoa[0, 0], Pessoa[0, 1], Pessoa[0, 2], Pessoa[0, 3]);
                Console.WriteLine(pessoa.ToString());
                Console.Write("\nDados da 2º Pessoa: ");
                Pessoa pessoa1 = new Pessoa(Pessoa[1, 0], Pessoa[1, 1], Pessoa[1, 2], Pessoa[1, 3]);
                Console.WriteLine(pessoa1.ToString());
                Console.Write("\nDados da 3º Pessoa: ");
                Pessoa pessoa2 = new Pessoa(Pessoa[2, 0], Pessoa[2, 1], Pessoa[2, 2], Pessoa[2, 3]);
                Console.WriteLine(pessoa2.ToString());
            }

        }
    }
}
