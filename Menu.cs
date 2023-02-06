using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOption();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        } // metodo para configuração de cores

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("+");
            }

            Console.Write("-");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write("-");
                }

                Console.Write("+");
                Console.Write("\n");
            }
        } // Estrutura de linhas (Desenhando uma tela)

        public static void WriteOption()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("EditorHtml");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Opção: ");
        } // Escreve opções para usuario

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }


                default: show(); break;
            }
        } // manipular as opções do nosso editor.

    }
}

/* 

    Anotações:

    - SetCursorPosition colocar o curso na tela onde posição que foi mencionada.
    - Foi criado 3 metodos;
        => WriteOption() com algoritmo para escrever opções para usuario.
        => DrawScreen() usando a interação de controle for() cria-se a estrutura
        de linhas do editor.
        => Metodo show() ao qual possui sua chamadas dos metodos abaixo e declarações
        dos cores de fundo e letras.
    - Na class program utilizamos os metodo principal para chamar a class Menu.show para
    acessar as demais funções da aplicação.
    - Para metodo HandleMenuOption vamos manipular as opções do nosso editor.
    - Variavel option criada para armazenar opções do usuario no sistema.


 */


