float altura = 0.0F;
float largura = 0.0F;

Console.Write("Digite a altura do seu retângulo: ");
string altura_str = Console.ReadLine()!;
altura = Convert.ToSingle(altura_str);

Console.Write("Digite a largura do seu retângulo: ");
string largura_str = Console.ReadLine()!;
largura = Convert.ToSingle(largura_str);

float area = 0.0F;
area = largura * altura;

if (altura == largura){
    Console.WriteLine("Você digitou medidas de um quadrado! Digite as medidas novamente." + "\n");
}
else{
    Console.WriteLine("A área do seu retângulo é: " + area);
}

Console.WriteLine("\n");