using _7_dados_e_listas_com_.net_c_.Models;
using System.Globalization;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Sobrenome = "Silva";
pessoa1.Idade = 30;
pessoa1.Apresentar();

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Maria";
pessoa2.Sobrenome = "Oliveira";
pessoa2.Idade = 25;
pessoa2.Apresentar();

Pessoa pessoa3 = new Pessoa("Carlos", "Santos", 40);
pessoa3.Apresentar();

Pessoa pessoa4 = new Pessoa(nome: "Ana", sobrenome: "Souza", idade: 20);
pessoa4.Apresentar();

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);

cursoDeIngles.ListarAlunos();

// ######################### formatando valores monetários, personalizando e porcentagem #########################
// Configura a cultura para exibir valores monetários

// Define a cultura padrão para o thread atual
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 82.40m;

// Exibe o valor monetário formatado como moeda
Console.WriteLine($"Valor monetário: {valorMonetario:C}");

// Exibe o valor monetário formatado como moeda em uma cultura específica
Console.WriteLine($"Valor monetário: {valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");

Console.WriteLine($"Valor monetário: {valorMonetario.ToString("C3")}");

double porcentagem = .2521;

Console.WriteLine($"Porcentagem: {porcentagem:P}");

int numero = 123456;

Console.WriteLine($"Número formatado: {numero.ToString("##-##-##")}");

// ######################### formatando datetime - data e hora #########################

DateTime dataAtual = DateTime.Now;
Console.WriteLine($"Data atual: {dataAtual}");
Console.WriteLine($"Data atual: {dataAtual.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Data atual: {dataAtual.ToString("dd/MM/yyyy HH:mm")}");

Console.WriteLine($"Data atual: {dataAtual.ToShortDateString()}");
Console.WriteLine($"Data atual: {dataAtual.ToShortTimeString()}");

// Converte uma string para DateTime
DateTime dataConvertida = DateTime.Parse("2023-10-01 15:30");

Console.WriteLine($"Data convertida: {dataConvertida}");

string dataString = "2023-10-01 15:30";
DateTime.TryParseExact(
                                            dataString,
                                            "yyyy-MM-dd HH:mm",
                                            CultureInfo.InvariantCulture,
                                            DateTimeStyles.None,
                                            out DateTime dataConvertidaResult
                                            );
Console.WriteLine($"Data convertida com TryParseExact: {dataConvertidaResult}");


bool conversaoComSucesso = DateTime.TryParse("2023-10-01 15:30", out DateTime dataConvertidaResult1);
if (conversaoComSucesso)
{
    Console.WriteLine($"Data convertida com TryParse - SUCESSO: {dataConvertidaResult1}");
}
else
{
    Console.WriteLine("Conversão falhou.");
}

// ######################### exceções e coleções - realizando a leitura de um arquivo #########################
// ######################### exceções e coleções - tratando uma exceção #########################
// ######################### exceções e coleções - exceção genéria e específica #########################
// ######################### exceções e coleções - entendendo o bloco finally #########################

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo77Leitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}
finally
{
    Console.WriteLine("Operação de leitura finalizada.");
}


// ######################### exceções e coleções - usando o Throw #########################

ExemploExcecao exemploExcecao = new ExemploExcecao();
exemploExcecao.metodo1();

// ######################### fila na pratica #########################

Queue<int> fila = new Queue<int>();
fila.Enqueue(1);
fila.Enqueue(4);
fila.Enqueue(7);
Console.WriteLine($"Primeiro elemento da fila: {fila.Peek()}");
foreach (int item in fila)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o primeiro elemento da fila: {fila.Dequeue()}");

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("Adicionando novo elemento à fila:");
fila.Enqueue(5);
fila.Enqueue(10);
foreach (int item in fila)
{
    Console.WriteLine(item);
}

// ######################### pilha na pratica #########################

Stack<int> pilha = new Stack<int>();
pilha.Push(1);
pilha.Push(4);
pilha.Push(7);
pilha.Push(9);
Console.WriteLine($"Topo da pilha: {pilha.Peek()}");
foreach (int item in pilha)
{
    Console.WriteLine($"Item da pilha: {item}");
}

Console.WriteLine($"Removendo o topo da pilha: {pilha.Pop()}");

pilha.Push(50);
foreach (int item in pilha)
{
    Console.WriteLine($"Item da pilha: {item}");
}

// ######################### introdução Dictionary #########################

// Dicionário é uma coleção de pares chave-valor
// Ele permite acesso rápido aos valores através das chaves
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");
estados["BA"] = "Bahia"; // Outra forma de adicionar elementos


foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("MG");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}


string chave = "SP";
// ContainsKey verifica se a chave existe no dicionário
Console.WriteLine($"Verificando se o elemento {chave} existe no dicionário: {estados.ContainsKey(chave)}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"O estado {chave} existe no dicionário.");
}
else
{
    Console.WriteLine($"O estado {chave} não foi encontrado no dicionário.");
}

// Acessando o valor de uma chave específica
Console.WriteLine(estados["SP"]);