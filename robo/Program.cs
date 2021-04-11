using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo
{
    class Program
    {
        static void Main(string[] args)
        {
            int coordenadaX, coordenadaY, coordenadaRoboX, coordenadaRoboY, quantCaracter;
            string posicao, comando;
            //robo1
            Console.WriteLine("CONFIGURAÇÃO DO ROBÔ 1: ");

            Console.WriteLine("-------Digite o tamanho da área --------------");
            Console.WriteLine("Digite o número de linhas do grid: ");
            coordenadaX = Convert.ToInt32(Console.ReadLine()); //ToInt32 pois indica os bits 
            Console.WriteLine("Digite o número de colunas do grid: ");
            coordenadaY = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[coordenadaX, coordenadaY];

            //segundo input posiçao 12

            Console.WriteLine("------Digite a posição do Robô 1-------------");
            Console.WriteLine("Digite a linha inicial do robô 1: ");
            coordenadaRoboX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a coluna inicial do robô 1: ");
            coordenadaRoboY = Convert.ToInt32(Console.ReadLine());

            //direção N

            posicao = MostraMenuPosicao();

            //terceiro input comando EMEMEMEMM

            comando = LeComando();

            //quantidade de caracter

            quantCaracter = comando.Length;

            //apresenta dados inputados
            ApresentaDados(coordenadaX, coordenadaY, coordenadaRoboX, coordenadaRoboY, posicao, comando);

            //execução usando substring para separar os caracteres juntos digitados pelo usuário e percorrer letra por letra

            for (int i = 0; i < quantCaracter; i++)
            {
                if (posicao != "N" && posicao != "S" && posicao != "L" && posicao != "O")
                {
                    OpcaoInvalida();
                }
                if (comando.Substring(i, quantCaracter) != "E" && comando.Substring(i, quantCaracter) != "D" && comando.Substring(i, quantCaracter) != "M")
                {
                    OpcaoInvalida();
                }
                if (posicao == "N" && comando.Substring(i, 1) == "M")
                {
                    coordenadaRoboY++;
                }
                if (posicao == "S" && comando.Substring(i, 1) == "M")
                {
                    coordenadaRoboY--;
                }
                if (posicao == "O" && comando.Substring(i, 1) == "M")
                {
                    coordenadaRoboX--;
                }
                if (posicao == "L" && comando.Substring(i, 1) == "M")
                {
                    coordenadaRoboX++;
                }

                if (comando.Substring(i, 1) == "E" || comando.Substring(i, 1) == "D")
                {
                    if (posicao == "N" && comando.Substring(i, 1) == "E")
                    {
                        posicao = "O";
                    }
                    else if (posicao == "N" && comando.Substring(i, 1) == "D")
                    {
                        posicao = "L";
                    }
                    else if (posicao == "S" && comando.Substring(i, 1) == "D")
                    {
                        posicao = "O";
                    }
                    else if (posicao == "S" && comando.Substring(i, 1) == "E")
                    {
                        posicao = "L";
                    }
                    else if (posicao == "L" && comando.Substring(i, 1) == "D")
                    {
                        posicao = "S";
                    }
                    else if (posicao == "L" && comando.Substring(i, 1) == "E")
                    {
                        posicao = "N";
                    }
                    else if (posicao == "O" && comando.Substring(i, 1) == "D")
                    {
                        posicao = "N";
                    }
                    else if (posicao == "O" && comando.Substring(i, 1) == "E")
                    {
                        posicao = "S";
                    }

                }

            }
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine($"O robô 1 finaliza na posição {coordenadaRoboX} X {coordenadaRoboY} com face virada para o {posicao}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            //robo2
            Console.WriteLine("CONFIGURAÇÃO DO ROBÔ 2: ");

            //input posiçao 33

            Console.WriteLine("------Digite a posição do Robô 2-------------");
            Console.WriteLine("Digite a linha inicial do robô 2: ");
            coordenadaRoboX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a coluna inicial do robô 2: ");
            coordenadaRoboY = Convert.ToInt32(Console.ReadLine());

            //direção L

            Console.WriteLine("------Digite a direção do Robô 2-------------");
            Console.WriteLine("Digite N para Norte");
            Console.WriteLine("Digite S para Sul");
            Console.WriteLine("Digite L para Leste");
            Console.WriteLine("Digite O para Oeste");
            posicao = Console.ReadLine();

            //terceiro input comando MMDMMDMDDM

            Console.WriteLine("------Digite os comandos de exploração da área-------------");
            Console.WriteLine("Digite E para mover 90° para a esquerda");
            Console.WriteLine("Digite D para mover 90° para a direita");
            Console.WriteLine("Digite M para mover para frente");
            comando = Console.ReadLine();

            //quantidade de caracter

            quantCaracter = comando.Length;

            //apresenta dados inputados
            Console.Clear();
            Console.WriteLine($"tamanho do grid {coordenadaX} X {coordenadaY}");
            Console.WriteLine($"O robô 2 inicia na posição {coordenadaRoboX} X {coordenadaRoboY} com face virada para o {posicao}");
            Console.WriteLine($"executará os comandos {comando}");

            //execução usando substring para separar os caracteres juntos digitados pelo usuário e percorrer letra por letra

            for (int i = 0; i < quantCaracter; i++)
            {
                if (posicao == "N" && comando.Substring(i, 1) == "M")
                {
                    coordenadaRoboY++;
                }
                if (posicao == "S" && comando.Substring(i, 1) == "M")
                {
                    coordenadaRoboY--;
                }
                if (posicao == "O" && comando.Substring(i, 1) == "M")
                {
                    coordenadaRoboX--;
                }
                if (posicao == "L" && comando.Substring(i, 1) == "M")
                {
                    coordenadaRoboX++;
                }

                if (comando.Substring(i, 1) == "E" || comando.Substring(i, 1) == "D")
                {
                    if (posicao == "N" && comando.Substring(i, 1) == "E")
                    {
                        posicao = "O";
                    }
                    else if (posicao == "N" && comando.Substring(i, 1) == "D")
                    {
                        posicao = "L";
                    }
                    else if (posicao == "S" && comando.Substring(i, 1) == "D")
                    {
                        posicao = "O";
                    }
                    else if (posicao == "S" && comando.Substring(i, 1) == "E")
                    {
                        posicao = "L";
                    }
                    else if (posicao == "L" && comando.Substring(i, 1) == "D")
                    {
                        posicao = "S";
                    }
                    else if (posicao == "L" && comando.Substring(i, 1) == "E")
                    {
                        posicao = "N";
                    }
                    else if (posicao == "O" && comando.Substring(i, 1) == "D")
                    {
                        posicao = "N";
                    }
                    else if (posicao == "O" && comando.Substring(i, 1) == "E")
                    {
                        posicao = "S";
                    }

                }

            }
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine($"O robô 2 finaliza na posição {coordenadaRoboX} X {coordenadaRoboY} com face virada para o {posicao}");
            Console.ReadLine();

            //POSSÍVEIS BUGS:
            //digitar algo diferente de int na área e nas coordenadas;
            //digitar algo diferente de N/S/L/O nas direções;
            //tamanho da área não ser suficiente para executar os comandos;


        }

        private static void OpcaoInvalida()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Opção inválida! Tente novamente.");

            Console.ResetColor();

            Console.ReadLine();

            Console.Clear();
        }

        private static void ApresentaDados(int coordenadaX, int coordenadaY, int coordenadaRoboX, int coordenadaRoboY, string posicao, string comando)
        {
            Console.Clear();
            Console.WriteLine($"tamanho do grid {coordenadaX} X {coordenadaY}");
            Console.WriteLine($"O robô 1 inicia na posição {coordenadaRoboX} X {coordenadaRoboY} com face virada para o {posicao}");
            Console.WriteLine($"executará os comandos {comando}");
        }

        private static string LeComando()
        {
            string comando;
            Console.WriteLine("------Digite os comandos de exploração da área-------------");
            Console.WriteLine("Digite E para mover 90° para a esquerda");
            Console.WriteLine("Digite D para mover 90° para a direita");
            Console.WriteLine("Digite M para mover para frente");
            comando = Console.ReadLine();
            return comando;
        }

        private static string MostraMenuPosicao()
        {
            string posicao;
            Console.WriteLine("------Digite a direção do Robô 1-------------");
            Console.WriteLine("Digite N para Norte");
            Console.WriteLine("Digite S para Sul");
            Console.WriteLine("Digite L para Leste");
            Console.WriteLine("Digite O para Oeste");
            posicao = Console.ReadLine();
            return posicao;
        }
    }
}
