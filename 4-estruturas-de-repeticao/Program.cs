// See https://aka.ms/new-console-template for more information

// ################################# introdução ao for #################################
int numero = 10;
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}


// ################################# introdução ao while #################################

int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}

// ################################# interrompendo o fluxo de execução #################################
Console.WriteLine("Interrompendo o loop quando contador é igual a 5");
contador = 0; // Reinicializando contador para demonstrar o uso do break
while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
    if (contador == 5)
    {
        Console.WriteLine($"Contador chegou a {contador}, interrompendo o loop.");
        break; // Interrompe o loop quando contador é igual a 5
    }
}

// ################################# introdução ao do while #################################
int soma = 0, x = 0;


do
{
    Console.WriteLine("Digite um número para somar (ou 0 para sair):");
    x = Convert.ToInt32(Console.ReadLine());
    
    soma += x; // Adiciona o número à soma
} while (x != 0); // Continua enquanto o número não for 0

Console.WriteLine($"A soma dos números digitados é: {soma}");

// ################################# construindo menu interativo #################################
string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    // Console.Clear(); // Limpa a tela para uma melhor visualização
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1. Cadastrar cliente");
    Console.WriteLine("2. Buscar cliente");
    Console.WriteLine("3. Excluir cliente");
    Console.WriteLine("4. Sair");
    Console.WriteLine("Escolha uma opção: ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar cliente.");
            break;

        case "2":
            Console.WriteLine("Buscar cliente.");
            break;

        case "3":
            Console.WriteLine("Apagar cliente.");
            break;

        case "4":
            Console.WriteLine("Saindo do programa...");
            // Environment.Exit(0); // Encerra o programa imediatamente
            exibirMenu = false; // Define que não deve exibir o menu novamente
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
// ################################# introdução ao foreach #################################
string[] frutas = { "Maçã", "Banana", "Laranja", "Uva", "Pera" };
foreach (string fruta in frutas)
{
    Console.WriteLine($"Eu gosto de {fruta}");
}   