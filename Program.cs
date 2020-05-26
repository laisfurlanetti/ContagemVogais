using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            int Espaco, Vogal;

            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine().ToLower();

            Espaco = ObterEspaco(frase);
            Vogal = ObterVogal(frase);

            Console.WriteLine("A quantidade de espaços e: " + Espaco);
            Console.WriteLine("A quantidade de vogais e: " + Vogal);

            Console.ReadLine();
        }

        public static int ObterVogal(string sentence)
        {
            int Vogal = 0;

            char[] fraseInserida = sentence.ToCharArray();

            for (int i = 0; i < fraseInserida.Length; i++)
            {
                if (fraseInserida[i].ToString() == "a")
                    Vogal++;
                if (fraseInserida[i].ToString() == "e")
                    Vogal++;
                if (fraseInserida[i].ToString() == "i")
                    Vogal++;
                if (fraseInserida[i].ToString() == "o")
                    Vogal++;
                if (fraseInserida[i].ToString() == "u")
                    Vogal++;
            }
            return Vogal;
        }

        public static int ObterEspaco(string sentence)
        {
            int Espaco = 0;

            char[] fraseInserida1 = sentence.ToCharArray();

            for (int i = 0; i < fraseInserida1.Length; i++)
            {
                if (fraseInserida1[i].ToString() == " ")
                    Espaco++;
            }

            return Espaco;
        }
    }
    
}
