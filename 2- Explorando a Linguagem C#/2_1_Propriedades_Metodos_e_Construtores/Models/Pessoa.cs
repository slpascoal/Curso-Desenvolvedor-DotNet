using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace códigos.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        
        public Pessoa(string Nome, string Sobrenome, int Idade)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Idade = Idade;
        }

        private string _nome;
        private int _idade;
        public string Nome
        { 
            get => _nome;
            
            set
            {
                if (value =="")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade
        {
            get => _idade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Idade não pode ser igual ou menor que zero (0)");
                }
                _idade = value;
            } 
        }
        public void Falar()
        {
            Console.WriteLine($"Olá, me chamo {NomeCompleto} e tenho {Idade} anos");
        }
    }
}