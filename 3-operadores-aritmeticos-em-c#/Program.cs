using operadores_aritmeticos_em_c_.Models;
// See https://aka.ms/new-console-template for more information

// ###################### operadores aritmeticos em c# ######################

Calculadora calculadora = new Calculadora();
calculadora.Somar(30, 10);
calculadora.Subtrair(10, 50);
calculadora.Multiplicar(15, 45);
calculadora.Dividir(2, 2);

// ###################### usando potencia ######################

calculadora.Potencia(2, 3);

// ###################### funções trigonométicas ######################

calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);

// ###################### incremento e decremento ######################

int a = 10;
int b = 5;

Console.WriteLine($"Valor inicial de a: {a}");
Console.WriteLine($"Valor inicial de b: {b}");

a++; // Incremento
b--; // Decremento

Console.WriteLine($"Valor de a após incremento: {a}");
Console.WriteLine($"Valor de b após decremento: {b}");

// ###################### Calculando raiz quadrada ######################

calculadora.RaizQuadrada(25);
calculadora.RaizQuadrada(-9);