using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7_dados_e_listas_com_.net_c_.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        // Atributos privados
        // Atributos são variáveis que armazenam o estado do objeto
        // Eles geralmente são privados para proteger os dados
        // e são acessados através de propriedades
        // Atributos são como campos, mas com encapsulamento
        // e podem ter lógica de validação
        private string _nome;
        private int _idade;

        // Propriedades com corpo de expressão
        // Propriedades são como atributos, mas com métodos de acesso (get/set)
        // Elas permitem encapsulamento e validação de dados
        public string Nome
        {
            // body expression
            get => _nome.ToUpper(); // Retorna o nome em letras maiúsculas
            // get
            // {
            //     return _nome.ToUpper(); // Retorna o nome em letras maiúsculas
            // }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio.");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Propriedade somente leitura que retorna o nome completo

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa.");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}