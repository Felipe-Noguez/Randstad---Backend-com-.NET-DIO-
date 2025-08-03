using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace operadores_aritmeticos_em_c_.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"A soma de {x} + {y} é igual a {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"A subtração de {x} - {y} é igual a {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"A multiplicação de {x} * {y} é igual a {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"A divisão de {x} / {y} é igual a {x / y}");
        }

        public void Potencia(int x, int y)
        {
            Console.WriteLine($"A potencia de {x} ^ {y} é igual a {Math.Pow(x, y)}");
        }

        public void Seno(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            double seno = Math.Sin(radianos);
            Console.WriteLine($"O seno de {angulo} graus é igual a {Math.Round(seno, 4)}");
            // Alternativa sem conversão de graus para radianos
            Console.WriteLine($"O seno de {angulo}º graus é igual a {Math.Sin(radianos)}");
        }

        public void Coseno(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            double coseno = Math.Cos(radianos);
            Console.WriteLine($"O coseno de {angulo}º é igual a {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            double tangente = Math.Tan(radianos);
            Console.WriteLine($"A tangente de {angulo}º é igual a {Math.Round(tangente, 4)}");
        }
        
        public void RaizQuadrada(double numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
            }
            else
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine($"A raiz quadrada de {numero} é igual a {Math.Round(raiz, 4)}");
            }
        }
    }
}