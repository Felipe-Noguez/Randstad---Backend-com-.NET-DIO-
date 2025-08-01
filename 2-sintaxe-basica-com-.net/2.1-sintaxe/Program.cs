// ######################## Exemplo da aula ########################
using sintaxe_e_tipos_de_dados.Models;
// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Instanciando objetos das classes Pessoa e PessoaCopy
// A classe Pessoa está no namespace sintaxe_e_tipos_de_dados.Models
// adicionando o namespace para evitar conflitos (também é possível adicionar com prefixo completo)
Pessoa pessoa = new();

pessoa.Nome = "João";
pessoa.Idade = 30;
pessoa.Apresentar();

// Pessoa pessoa = new Pessoa("João", 30);
// pessoa.Apresentar();




// ######################## 2 forma de resolver o conflito de nomes ########################


// Sem o uso de "using" para os namespaces.
// desta forma abaixo, funciona
// Cria uma instância da classe Pessoa do primeiro namespace
// sintaxe_e_tipos_de_dados.Models.Pessoa pessoa = new sintaxe_e_tipos_de_dados.Models.Pessoa("João", 30);
// pessoa.Apresentar();

// Cria uma instância da classe Pessoa do segundo namespace
// sintaxe_e_tipos_de_dados.PessoaCopy.Models.Pessoa pessoaCopy = new sintaxe_e_tipos_de_dados.PessoaCopy.Models.Pessoa("Maria", 25);
// pessoaCopy.ApresentarCopy();

// ######################## 3 forma de resolver o conflito de nomes ########################

// Define um alias (por exemplo, "Original") para o primeiro namespace
// using Original = sintaxe_e_tipos_de_dados.Models;

// Define um alias (por exemplo, "Copia") para o segundo namespace
// using Copia = sintaxe_e_tipos_de_dados.PessoaCopy.Models;

// // Agora, você pode usar os apelidos para diferenciar as classes
// Original.Pessoa pessoa = new Original.Pessoa("João", 30);
// pessoa.Apresentar();

// Copia.Pessoa pessoaCopy = new Copia.Pessoa("Maria", 25);
// pessoaCopy.ApresentarCopy();

// ######################## Tipos de dados ########################

string apresentacao = "Hello, World!";
int quantidade = 1;
quantidade = 10; // Atribuindo um novo valor à variável quantidade
double altura = 1.80;
decimal preco = 19.99M; // Usando 'm' para indicar que é um decimal
bool condicao = true; // Variável booleana

Console.WriteLine("Valor da variável apresentacao: " + apresentacao);
Console.WriteLine("Valor da variável quantidade:" + quantidade);
Console.WriteLine("Valor da variável altura:" + altura);
Console.WriteLine("Valor da variável altura:" + altura.ToString("F2")); // Formatação para 2 casas decimais
Console.WriteLine("Valor da variável preco:" + preco);
Console.WriteLine("Valor da variável condicao:" + condicao);

// ######################## Tipos de dados - Exemplo de uso de variáveis ########################

DateTime dataAtual = DateTime.Now; // Obtendo a data e hora atual
Console.WriteLine("Data e hora atual: " + dataAtual);

DateTime dataAdicionada = DateTime.Now.AddDays(5); // Adicionando 5 dias à data atual
Console.WriteLine("Data atual + 5 dias: " + dataAdicionada);

DateTime dataAdicionadaSemHora = DateTime.Now.Date.AddDays(5);
Console.WriteLine("Data atual + 5 dias (sem hora): " + dataAdicionadaSemHora.ToString("dd/MM/yyyy"));

DateTime dataAdicionadaSemSegundos = DateTime.Now.AddDays(5);
Console.WriteLine("Data atual sem segundos: " + dataAdicionadaSemSegundos.ToString("dd/MM/yyyy HH:mm"));