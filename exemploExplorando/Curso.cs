using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploExplorando
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAlunos(Pessoa Aluno)
        {
            Alunos.Add(Aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa Aluno)
        {
            return Alunos.Remove(Aluno);
        }

        public void listarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            foreach(Pessoa Aluno in Alunos)
            {
                Console.WriteLine(Aluno.NomeCompleto);
            }
        }
    }
}
