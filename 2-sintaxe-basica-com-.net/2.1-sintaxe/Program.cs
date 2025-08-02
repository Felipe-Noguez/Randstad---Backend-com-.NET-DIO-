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

// ######################## Introdução operador de atribuição ########################

int a = 10;
int b = 20;
int c = a + b;

c += 5; // Incrementando o valor de c em 5
c -= 3; // Decrementando o valor de c em 3
c *= 2; // Multiplicando o valor de c por 2

Console.WriteLine($"A soma de {a} + {b} é igual a {c}");

// ######################## Convertendo tipos (cast) ########################
int numero = Convert.ToInt32("123"); // Convertendo string para int
Console.WriteLine($"Número convertido: {numero}");

int numero2 = int.Parse("456"); // Convertendo string para int usando Parse
Console.WriteLine($"Número 2 convertido: {numero2}");

int numero3 = int.TryParse("456", out int resultado) ? resultado : 0; // Usando TryParse para conversão segura
Console.WriteLine($"Número 3 convertido: {numero3}");

//int numero4 = int.Parse("789texto"); 
//Console.WriteLine($"Número 4 convertido: {numero4}"); // Isso causará uma exceção se a string não for um número válido
// Exemplo de conversão que causará exceção
// Unhandled exception. System.FormatException: The input string '789texto' was not in a correct format.
//    at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)
//    at System.Int32.Parse(String s)
//    at Program.<Main>$(String[] args) in /home/felipe/Documents/workspaces/.NET/DIO/Randstad - Backend com .NET/2-sintaxe-basica-com-.net/2.1-sintaxe/Program.cs:line 101


// int.Parse não poder receber null ou string vazia, caso contrário, causará uma exceção
// int numero5 = int.Parse(null); // Isso causará uma exceção
// Convert.ToInt32(null); // Isso retornará 0, pois Convert lida com null

// ######################## Convertendo para string (cast) ########################
int d = 10;
string e = d.ToString(); // Convertendo int para string
Console.WriteLine($"Valor de e: {e}");


// ######################## Cast implícito ########################

int f = 10;
double g = f; // Cast implícito de int para double
Console.WriteLine($"Valor de g (double): {g}");

int h = 4;
long i = h; // Cast implícito de int para long
Console.WriteLine($"Valor de i (long): {i}");

long j = 100; // Exemplo de long
int k = Convert.ToInt32(j); // Convertendo long para int (pode causar perda de dados se o valor for muito grande)

// Neste caso a vairavel inteira não será capaz de armazenar o valor de j, pois é maior que o máximo permitido para int
//j = long.MaxValue; // Atribuindo o valor máximo de long
//k = Convert.ToInt32(j); // Convertendo long para int (pode causar perda de dados)
//Console.WriteLine($"Valor de k (int): {k}");
// Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32.
//    at System.Convert.ThrowInt32OverflowException()
//    at System.Convert.ToInt32(Int64 value)
//    at Program.<Main>$(String[] args) in /home/felipe/Documents/workspaces/.NET/DIO/Randstad - Backend com .NET/2-sintaxe-basica-com-.net/2.1-sintaxe/Program.cs:line 131



// ######################## Ordem dos operadores (ordem de precedência) ########################

double resultadoSoma = 4 / 2 + 2; // A divisão é feita antes da adição
Console.WriteLine($"Resultado da expressão 4 / 2 + 2: {resultadoSoma}");

double resultadoMultiplicacao = (10 + 5) * 2; // A expressão entre parênteses é avaliada primeiro, depois a multiplicação
Console.WriteLine($"Resultado da expressão (10 + 5) * 2: {resultadoMultiplicacao}");

// ######################## Convertendo de maneira segura ########################
string textoNumero = "15-";
int numeroZero = 0;

int.TryParse(textoNumero, out numeroZero); // Tentando converter string para int de forma segura
Console.WriteLine($"Número convertido de forma segura: {numeroZero}");

// int numeroSeguro = Convert.ToInt32(textoNumero); // Desta forma, se a conversão falhar, causará uma exceção, pois no caso,
//  a string "15-" não é um número válido.
// Console.WriteLine($"Número convertido de forma segura: {numeroSeguro}");  

Console.WriteLine($"Conversão realizada com sucesso");

string textoNumero2 = "123";
if (int.TryParse(textoNumero2, out int numeroConvertido))
{
    Console.WriteLine($"Número convertido com sucesso: {numeroConvertido}");
}
else
{
    Console.WriteLine("Falha na conversão.");
}


// ######################## Operadores condicionais ########################
int quantidadeProdutos = 10;
bool temEstoque = quantidadeProdutos > 0 ? true : false; // Usando operador ternário para verificar se há estoque
Console.WriteLine($"Tem estoque? {temEstoque}");

int quantidadeCompra = 0;
bool posivelVenda = quantidadeCompra > 0 &&quantidadeProdutos >= quantidadeCompra; //? true : false; // Verificando se é possível realizar a compra

Console.WriteLine($"Quantidade solicitada: {quantidadeCompra}");
Console.WriteLine($"Quantidade disponível em estoque: {quantidadeProdutos}");
Console.WriteLine($"É possível realizar a compra: {posivelVenda}");

if (posivelVenda)
{
    Console.WriteLine("Quantidade solicitada disponível em estoque.");
}
else
{
    Console.WriteLine("Quantidade solicitada não disponível em estoque.");
}


if (quantidadeCompra > quantidadeProdutos)
{
    Console.WriteLine("Quantidade solicitada maior que a disponível em estoque.");
}
else
{
    Console.WriteLine("Compra realizada com sucesso.");
}

// ######################## if aninhado ########################
Console.WriteLine("if aninhado");
if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelCompra)
{
    Console.WriteLine("Quantidade solicitada disponível em estoque.");
}
else
{
    Console.WriteLine("Quantidade solicitada não disponível em estoque.");
}