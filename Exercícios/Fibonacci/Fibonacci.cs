using System;

class Program{
    static void Fibonnaci(int numero){
        int numeroAnterior = 0;
        int proxNumero = 1;
        int aux = 2;;

        if(numero == 0){
            Console.WriteLine(numero);
            return;
        }

        Console.Write(0 + ", " + proxNumero);

        while(true){
            int numeroAtual = numeroAnterior + proxNumero;

            if (numeroAtual <= numero){
                Console.Write(", " + numeroAtual);
                numeroAnterior = proxNumero;
                proxNumero = numeroAtual;
            }
            else{
                Console.Write(".");
                break;
            }
        } 
    }

    static void Main()
    {
        int numero;

        while (true){
            Console.Write("Digite um número inteiro positivo: ");
            string numero_str = Console.ReadLine();
            numero = Convert.ToInt32(numero_str);

            if (numero < 0){
                Console.WriteLine("Digite um número positivo!");
            }
            else{
                break;
            }
        }

        Fibonnaci(numero);
        Console.WriteLine("\n");
    }
}