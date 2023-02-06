using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {
        public static void show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("------------");
            Replace(text);
            Console.WriteLine("------------");
            Console.ReadKey();
            Menu.show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring('>') + 1,
                        (
                            (words[i].LastIndexOf('<')) - 1 -
                            words[i].IndexOf('>')
                        )
                    );
                    Console.Write(" ");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.WriteLine(" ");
                }

            }

        }

    }
}

/* 
    Anotações:

    links complementares:
    https://www.alura.com.br/artigos/regex-c-sharp-utilizar-expressoes-regulares?gclid=CjwKCAiAxP2eBhBiEiwA5puhNW9wD7MbjhkWxxKBUYzpZNd1d69e7Urs4-Zpl79YDK8wAOMIQjWxgRoCVEQQAvD_BwE



 */