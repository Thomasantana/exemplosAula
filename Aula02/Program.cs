// See https://aka.ms/new-console-template for more information
using Aula02._1bim;
using System.Xml.Serialization;

//int num1 = 20;
//int num2 = 2;
//int soma = num1 + num2;

//Console.WriteLine($"O resultado foi {soma}");

Console.WriteLine("informe sua idade: ");
int idade;
idade = int.Parse(Console.ReadLine());
Console.WriteLine("Minha idade:" + idade);

int valor1 = 10;
valor1 += 20; //valor1 = valor1 + 20

SomaDoisNumeros somador;
somador = new SomaDoisNumeros();

Console.WriteLine("Resultado :" + somador.Somar(20, 22));
