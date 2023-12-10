using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using códigos.Models;

namespace códigos.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno); //Nesse caso, o método Remove() retornoa um valor booleano, podendo ser aproveitado como retorno
        }

        public void ListarAlunos()
        {
            foreach(Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}