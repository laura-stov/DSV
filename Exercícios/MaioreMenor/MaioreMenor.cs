int numero1;
int numero2;

Console.Write("Digite o primeiro número: ");
string numero1_str = Console.ReadLine();
Console.Write("Digite o segundo número: ");
string numero2_str = Console.ReadLine();

numero1 = Convert.ToInt32(numero1_str);
numero2 = Convert.ToInt32(numero2_str);

if (numero1 < numero2){
    Console.WriteLine($"\nO maior número é: {numero2}\n" + $"O menor número é {numero1}");
}
else if (numero1 > numero2){
    Console.WriteLine($"\nO maior número é: {numero1}\n" + $"O menor número é {numero2}");
}
else{
    Console.WriteLine("\nOs números digitados são iguais!");
}
Console.WriteLine("\n");