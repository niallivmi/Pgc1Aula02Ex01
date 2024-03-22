//@niallivmi
using System;

namespace Pgc1Aula02Ex01

{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;

            Console.Write("Digite a nota do primeiro bimestre: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota do segundo bimestre: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("A nota do estudante é: " + ((n1 + n2) / 2));
        }
    }
}
