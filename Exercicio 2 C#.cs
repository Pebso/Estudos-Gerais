// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bom dia!");

string frase = Console.ReadLine();

int n1 = int.Parse (Console.ReadLine());
char ch = char.Parse (Console.ReadLine());
double n2 = double.Parse (Console.ReadLine());

string s = Console.ReadLine();

string[] vet = s.Split(' ');

string nome = vet[0];
char sexo = char.Parse (vet[1]);
int idade = int.Parse (vet[2]);
double altura = double.Parse (vet[3]);

double valor1 = 0;
double valor2 = 0;


Console.WriteLine("Você digitou");
Console.WriteLine(frase);
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2);
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura);