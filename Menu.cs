using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void show()
        {
            /* Configuração de cores de fundo do editor */
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            /* Chamando funções */
            DrawScreen();
            WriteOption();

            /* Lendo uma linha com a var (option) */
            var option = short.Parse(Console.ReadLine());
            /* Passando option para chamada do metodo */
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            /* 1° for criando colunas */
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("+");
            }

            Console.Write("-");
            Console.Write("\n");

            /* 2° Criando as linhas */
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("+");
                Console.Write("\n");
            }
        }

        public static void WriteOption()
        {
            /* Opções para tela do usuario */
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
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            /* Manipulando as options da tela do usuario */
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
        }

    }
}

/* 

    Anotações:

    - SetCursorPosition colocar o curso na tela onde posição que foi mencionada.
    - Foi criado 3 metodos;
        => WriteOption() com algoritmo para escrever opções para usuario.
        => DrawScreen() usando a interação de controle for() cria-se a estrutura
        de linhas do editor. (Desenhando telas)
        => Metodo show() ao qual possui sua chamadas dos metodos abaixo e declarações
        dos cores de fundo e letras.
    - Na class program utilizamos os metodo principal para chamar a class Menu.show para
    acessar as demais funções da aplicação.
    - Para metodo HandleMenuOption vamos manipular as opções do nosso editor.
    - Variavel option criada para armazenar opções do usuario no sistema.
    - Propriedades do console.brack/fore sao para cores do terminal.
    - Usando metodo setCursorPosition() ele seta o curso onde queremos que ele fique na tela
    do editor.


 */


