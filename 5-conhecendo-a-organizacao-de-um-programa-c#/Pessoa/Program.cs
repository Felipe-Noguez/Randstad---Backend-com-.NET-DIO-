// ################################# organizando e referenciando projetos #################################
using sintaxe_e_tipos_de_dados.Common.Models;
using operadores_aritmeticos_em_c_.Common.Models;

Pessoa pessoa = new Pessoa("Felipe", 42);
pessoa.Apresentar();

































// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     // Console.Clear(); // Limpa a tela para uma melhor visualização
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1. Cadastrar cliente");
//     Console.WriteLine("2. Buscar cliente");
//     Console.WriteLine("3. Excluir cliente");
//     Console.WriteLine("4. Sair");
//     Console.WriteLine("Escolha uma opção: ");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastrar cliente.");
//             break;

//         case "2":
//             Console.WriteLine("Buscar cliente.");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente.");
//             break;

//         case "4":
//             Console.WriteLine("Saindo do programa...");
//             // Environment.Exit(0); // Encerra o programa imediatamente
//             exibirMenu = false; // Define que não deve exibir o menu novamente
//             break;

//         default:
//             Console.WriteLine("Opção inválida. Tente novamente.");
//             break;
//     }
// }