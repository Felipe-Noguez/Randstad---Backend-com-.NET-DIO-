// using System.Globalization;
using _8_tuplas_operador_ternario_e_descontrucao_de_um_objeto_c_.Models;
// #################################### tupla na prática ####################################

(int, string, string) tupla = (1, "Felipe", "Noguez");
// (int Id, string Nome, string Sobrenome) tupla2 = (1, "Felipe", "Noguez");

Console.WriteLine(tupla.Item1); // Acessando o primeiro item da tupla
Console.WriteLine(tupla.Item2); // Acessando o segundo item da tupla
Console.WriteLine(tupla.Item3); // Acessando o terceiro item da tupla

// #################################### outra sintaxe da tupla ####################################

// declaração de tupla com tipos explícitos
ValueTuple<int, string, string> tupla3 = (1, "Felipe", "Noguez");
// exibindo os valores da tupla
Console.WriteLine(tupla3); // Exibindo a tupla completa
Console.WriteLine(tupla3.Item1); // Acessando o primeiro item da tupla
Console.WriteLine(tupla3.Item2); // Acessando o segundo item da tupla
Console.WriteLine(tupla3.Item3); // Acessando o terceiro item da tupla

// declaração de tupla com identificadores
var tupla4 = (Id: 1, Nome: "Felipe", Sobrenome: "Noguez");
// exibindo os valores da tupla
Console.WriteLine(tupla4.Id); // Acessando o primeiro item da tupla
Console.WriteLine(tupla4.Nome); // Acessando o segundo item da tupla
Console.WriteLine(tupla4.Sobrenome); // Acessando o terceiro item da tupla

var tupla5 = Tuple.Create(1, "Felipe", "Noguez");
Console.WriteLine(tupla5.Item1); // Acessando o primeiro item da tupla
Console.WriteLine(tupla5.Item2); // Acessando o segundo item da tupla
Console.WriteLine(tupla5.Item3); // Acessando o terceiro item da tupla

// #################################### tupla em métodos ####################################
// #################################### testando nosso método ####################################

LeituraArquivo leituraArquivo = new LeituraArquivo();
var (sucesso, linhas, quantidadeDeLinhas) = leituraArquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
if (sucesso)
{
    Console.WriteLine($"Arquivo lido com sucesso! Total de linhas: {quantidadeDeLinhas}");
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Erro ao ler o arquivo.");
}

var resultado = leituraArquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
if (resultado.Sucesso)
{
    Console.WriteLine($"Arquivo lido com sucesso! Total de linhas: {quantidadeDeLinhas}");
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Erro ao ler o arquivo.");
}

// desconstrução ignorando valores que não serão utilizados
var (sucesso1, linhas1, _) = leituraArquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
if (sucesso1)
{
    foreach (var linha in linhas1)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Erro ao ler o arquivo.");
}

// #################################### desconstrutor ####################################
Pessoa pessoa = new Pessoa("Felipe", "Noguez", 30);

var (nome, sobrenome, idade) = pessoa; // Desconstruindo o objeto Pessoa
Console.WriteLine("Desconstrução de objeto Pessoa:");
// Ou usando o método de desconstrução
Console.WriteLine($"Nome: {nome}, Sobrenome: {sobrenome}, Idade: {idade}");

// #################################### if ternário ####################################
var mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem);

int numero = 20;
var resultadoParImpar = numero % 2 == 0 ? "Par" : "Ímpar";
Console.WriteLine($"O número {numero} é {resultadoParImpar}.");


bool ehPar = false;
ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar") + ".");

// #################################### fim ####################################