using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Matematicos_Avançados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Potenciação
            double potenciacao = Math.Pow(4, 2);
            Console.WriteLine(potenciacao);

            //Radiciação
            double raiz = 3;
            double radiciacao = Math.Pow(27, 1/raiz);
            Console.WriteLine(radiciacao);

            //Máximo e o mínimo
            double maximo = Math.Max(4, 8);
            Console.WriteLine(maximo);

            double minimo = Math.Min(4, 8);
            Console.WriteLine(minimo);

            //Módulo
            double modulo = Math.Abs(-10);
            Console.WriteLine(modulo);

            //Operações Trigonométricas
            double angulo = 30 * (2 * Math.PI) / 360;

            //Para o Seno, utilizamos a expressão "Sin"
            //Para o Cosseno, utilizamos a expressão "Cos"
            //E para a tangente, utilizamos "Tan" 
            double seno = Math.Sin(angulo);
            Console.WriteLine(seno);

            //ArcSeno, utilizamos Asin
            //ArcCosseno, utilizamos Acon
            //ArcTangente, utilizamos Atan
            double arseno = Math.Asin(seno);
            Console.WriteLine(arseno);
            double arsenoGraus = arseno * 360/(2 * Math.PI);
            Console.WriteLine(arsenoGraus);

            //Arrendodamento de números
            double numero = 3.33;
            double arredondandoParaCima = Math.Ceiling(numero);
            Console.WriteLine(arredondandoParaCima);

            double arrendondandoParaBaixo = Math.Floor(numero);
            Console.WriteLine(arrendondandoParaBaixo);

            //Logaritmo
            double base10 = Math.Log10(100);
            Console.WriteLine(base10);

            double baseE = Math.Log(Math.E * Math.E * Math.E);
            Console.WriteLine(baseE);

            Console.ReadKey();
        }
    }
}
