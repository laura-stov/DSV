float real;
float dolar;
float euro;
float peso_arg;

Console.Write("Digite o valor em real a ser convertido: ");
string real_str = Console.ReadLine();
real = Convert.ToSingle(real_str);

dolar = real / 5.17F;
euro = real / 6.14F;
peso_arg = real / 0.05F;

Console.WriteLine("\n" + $"R$ {real} em dólar: US$ {dolar:F2}");
Console.WriteLine($"R$ {real} em euro: € {euro:F2}");
Console.WriteLine($"R$ {real} em peso argentino: $ {peso_arg:F2}");
Console.WriteLine("\n");
