using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxe_e_tipos_de_dados.PessoaCopy.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        // Construtor padrão
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ApresentarCopy()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}