using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Os parâmetros do método Main são passados pela linha de comando e podem ser manipulados
            dentro do programa. O código abaixo imprime cada parâmetro recebido em uma linha diferente.

            Os parâmetros devem ser passados imediatamente após o nome do programa.
            */

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.ReadLine();
        }
    }
}
