int idade;

Console.Write("Digite sua idade: ");
string idade_str = Console.ReadLine();
idade = Convert.ToInt32(idade_str);

if (idade < 0){
    Console.Write("Digite um valor válido!");
}
else if (idade <= 13){
    Console.Write("Você se classifica como uma criança.");
}
else if(13 < idade && idade <= 18){
    Console.Write("Você se classifica como um adolescente.");
}
else if(idade > 18 && idade <= 60){
    Console.Write("Você se classifica como um adulto.");
}
else{
    Console.Write("Você se classifica como um idoso.");
}
Console.WriteLine("\n");
