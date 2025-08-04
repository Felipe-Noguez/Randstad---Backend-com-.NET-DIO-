using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7_dados_e_listas_com_.net_c_.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            // Retorna a quantidade de alunos matriculados no curso
            if (Alunos == null)
            {
                return 0; // Se a lista de alunos for nula, retorna 0
            }
            // Caso contrário, retorna a contagem de alunos na lista
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            // Remove um aluno da lista de alunos
            if (Alunos != null && Alunos.Contains(aluno))
            {
                return Alunos.Remove(aluno);
                // return true; // Retorna true se o aluno foi removido com sucesso
            }
            return false; // Retorna false se o aluno não foi encontrado
        }
        
        public void ListarAlunos()
        {
            // Lista todos os alunos matriculados no curso
            if (Alunos == null || Alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno matriculado.");
                return;
            }

            Console.WriteLine($"Alunos matriculados no curso de {Nome}:");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}