using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace códigos.Models
{
    public class EstruturasDeRepeticao{
    
        public void LacoFor(int numero){
            Console.WriteLine($"--Taboada de {numero} - Usando FOR:--");
            for (int i = 0; i <= 10; i++){
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        
        public void LacoWhile(int numero){
            Console.WriteLine($"--Taboada de {numero} - Usando WHILE:--");
            int contadorWhile = 0;
            while (contadorWhile <= 10){
                Console.WriteLine($"{numero} x {contadorWhile} = {numero * contadorWhile}");
                contadorWhile++;
            }
        }

        public void LacoDoWhile(int numero){
            Console.WriteLine($"--Taboada de {numero} - Usando DO WHILE:--");
            int contadorDo = 0;
            do{
                Console.WriteLine($"{numero} x {contadorDo} = {numero * contadorDo}");
                contadorDo++;
            } while (contadorDo <= 10);
        }    
    }
}