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