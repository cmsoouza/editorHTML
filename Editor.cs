using System;
using System.Text;

namespace EditorHtml
{
    public class Editor
    {
        public static void Show()
        {
            /* Configurações de cores da tela do editor */
            /* Modo Edição do editor*/
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------");
            /* Chamando o metodo start */
            Start();
        }

        public static void Start()
        {
            /*  */
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------");
            Console.WriteLine(" Deseja salvar o arquivo?");
            Viewer.show(file.ToString());
        }
    }
}

/* 
    Anotações:

    - StringBuilder inicializar novas instancias na string principal.
    - Na estrutura do stringbuilder cria-se um algoritmo que emquanto
    o usuario nao clickar a tecla "Esc", ele nao sairá da tela do editor.
    


 */