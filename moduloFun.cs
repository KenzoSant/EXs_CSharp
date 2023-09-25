using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_1
{
    class Program
    {

        static int CalculaModulo(int n1, int n2) {

            int modulo;
            modulo = n1 % n2;

            return modulo;
        
        }
        static void Main(string[] args)
        {

            int n1, n2;

            Console.Write("Informe o 1º Numero :\n ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o 2º Numero :\n ");
            n2 = int.Parse(Console.ReadLine());

            int modulo = CalculaModulo(n1, n2);

            Console.Write("Modulo é: " + modulo);
            Console.ReadLine();
        }
    }
}