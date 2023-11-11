using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace códigos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} + {y} = {x - y}");
        }

        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x * y}");
        }

        public void Dividir(int x, int y){
            Console.WriteLine($"{x} + {y} = {x / y}");
        }

        public void Potencia(int x, int y){
            double result = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {result}");
        }

        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180 ;
            double result  = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(result, 4)}");
        }

        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180 ;
            double result  = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(result, 4)}");
        }

        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180 ;
            double result  = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(result, 4)}");
        }

        public void RaizQuadrada(double x){
            double result = Math.Sqrt(x);
            Console.WriteLine($"Raiz Quadrada de {x} = {result}");
        }
    }
}