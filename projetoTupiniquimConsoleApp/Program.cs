using System;

namespace projetoTupiniquimConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pXInicial, pYInicial;
            char direcaoAtual;
            string movimentosRobo;


            Console.WriteLine("Seja Bem vindo ao AEB");


            // vai criar até 2 robos por causa do laço de repetição
            for (int i = 0; i < 2; i++)
            {

                //Posiçao X
                Console.WriteLine("Digite uma posiçao inicial de X: ");

                pXInicial = Convert.ToInt32(Console.ReadLine());

                //Posiçao Y
                Console.WriteLine("Digite uma posiçao inicial de Y: ");

                pYInicial = Convert.ToInt32(Console.ReadLine());

                //Direção do robo N,S,L,O
                Console.WriteLine("Digite a direção atual (N,S,L,O): ");

                direcaoAtual = Convert.ToChar(Console.ReadLine().ToUpper());


                //movimento MMDDMMMEE
                Console.WriteLine("Digite um movimento: ");

                movimentosRobo = Console.ReadLine().ToUpper();

                char[] vetorOpcao = movimentosRobo.ToCharArray();// [m, m , m ,d, e]

                for (int p = 0; p < vetorOpcao.Length; p++)
                {
                    char op = vetorOpcao[p];

                    switch (op)
                    {// >
                        case 'D':
                            switch (direcaoAtual)
                            {
                                case 'N':
                                    direcaoAtual = 'L';
                                    break;

                                case 'S':
                                    direcaoAtual = 'O';
                                    break;

                                case 'O':
                                    direcaoAtual = 'N';
                                    break;

                                case 'L':
                                    direcaoAtual = 'S';
                                    break;

                            }
                            break;

                        //<
                        case 'E':
                            switch (direcaoAtual)
                            {
                                case 'N':
                                    direcaoAtual = 'O';
                                    break;

                                case 'S':
                                    direcaoAtual = 'L';
                                    break;

                                case 'O':
                                    direcaoAtual = 'S';
                                    break;

                                case 'L':
                                    direcaoAtual = 'N';
                                    break;

                            }
                            break;

                        //^
                        case 'N':
                            switch (direcaoAtual)
                            {
                                case 'N':
                                    direcaoAtual = 'N';
                                    break;

                                case 'S':
                                    direcaoAtual = 'S';
                                    break;

                                case 'O':
                                    direcaoAtual = 'O';
                                    break;

                                case 'L':
                                    direcaoAtual = 'L';
                                    break;

                            }
                            break;

                        //V
                        case 'S':
                            switch (direcaoAtual)
                            {
                                case 'N':
                                    direcaoAtual = 'S';
                                    break;

                                case 'S':
                                    direcaoAtual = 'N';
                                    break;

                                case 'O':
                                    direcaoAtual = 'L';
                                    break;

                                case 'L':
                                    direcaoAtual = 'O';
                                    break;

                            }
                            break;

default:                //^
                        case 'M':
                            switch (direcaoAtual)
                            {
                                //subir uma linha na posição Y
                                case 'N':
                                    pYInicial++;
                                    break;

                                //descer uma linha na posição Y
                                case 'S':
                                    pYInicial--;
                                    break;

                                //sair de uma coluna para a coluna anterior em X
                                case 'O':
                                    pXInicial--;
                                    break;

                                //sair de uma coluna para a coluna seguinte em X
                                case 'L':
                                    pXInicial++;
                                    break;

                            }
                            break;

                            
                    }
                }
                //Concatenar Variaveis, Obrigado Tales por me falar que isso era possivel
                Console.WriteLine(pXInicial + " " + pYInicial + " " + direcaoAtual);

            }
        }
    }
}
