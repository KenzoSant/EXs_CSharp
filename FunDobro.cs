using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_3
{
    class Program
    {
        static float CalculaDobro(float n1, float n2)
        {

            float final;
            final = (n1 * 2) + (n2 * 2);

            return final;

        }
        static void Main(string[] args)
        {

            float n1, n2, n3;

            Console.Write("Informe a 1º Nota :\n ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 2º Nota :\n ");
            n2 = float.Parse(Console.ReadLine());

            float final = CalculaDobro(n1, n2);
            flo

            Console.Write("Modulo é: " + final);
            Console.ReadLine();
        }
    }
}