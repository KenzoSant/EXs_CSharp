using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_2
{
    class Program
    {
        static float CalculaMedia(float n1, float n2, float n3)
        {

            float media;
            media = (n1 + (n2*2) + (n3*2)) / 5;

            return media;

        }
        static void Main(string[] args)
        {

            float n1, n2, n3;

            Console.Write("Informe a 1º Nota :\n ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 2º Nota :\n ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 3º Nota :\n ");
            n3 = float.Parse(Console.ReadLine());

            float media = CalculaMedia(n1, n2, n3);

            Console.Write("Modulo é: " + media);
            Console.ReadLine();
        }
    }
}