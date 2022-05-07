using System.Globalization;
Console.WriteLine("Pressione ENTER para iniciar");
double largura, comprimento, precoMetroQuadrado, area, preco;
Console.ReadLine();
Console.WriteLine("Largura");
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("comprimento");
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Preço do Metro Quadrado");
precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Resultado:");
area = largura * comprimento;
preco = area * precoMetroQuadrado;
Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Preço = " + preco.ToString("F2", CultureInfo.InvariantCulture));


