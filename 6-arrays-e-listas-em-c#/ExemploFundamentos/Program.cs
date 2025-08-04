// ############################ ARRAYS EM C# ############################

int [] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // Redimensiona o array para 8 elementos (resize cria um novo array e copia os valores)

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2]; // Cria um novo array com o dobro do tamanho
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length); // Copia os valores do array original para o novo array dobrado

// Percorrer o array com FOR
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Valor do índice {i}: {arrayInteiros[i]}");
}

// Percorrer o array com FOREACH
int contadorForEach = 0;
foreach (int numero in arrayInteiros)
{
    Console.WriteLine($"Posição {contadorForEach} valor do número: {numero}");
    contadorForEach++;
}

// ############################ LISTAS EM C# ############################

List<string> listaString = new List<string>();

listaString.Add("São Paulo");
listaString.Add("Rio de Janeiro");
listaString.Add("Belo Horizonte");
listaString.Add("Rio Grande do Sul");

Console.WriteLine($"Quantidade de elementos na lista: {listaString.Count}, capacidade: {listaString.Capacity}");

listaString.Add("Curitiba");
Console.WriteLine($"Quantidade de elementos na lista: {listaString.Count}, capacidade: {listaString.Capacity}");

listaString.Remove("Porto Alegre"); // Tentativa de remover um elemento que não existe
Console.WriteLine($"Quantidade de elementos na lista: {listaString.Count}, capacidade: {listaString.Capacity}");

// Percorrer a lista com FOR
for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Valor do índice {i}: {listaString[i]}");
}

// Percorrer a lista com FOREACH
int contadorForEachLista = 0;
foreach (string cidade in listaString)
{
    Console.WriteLine($"Posição {contadorForEachLista} valor da cidade: {cidade}");
    contadorForEachLista++;
}