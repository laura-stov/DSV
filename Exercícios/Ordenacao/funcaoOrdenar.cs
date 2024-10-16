using System;

class Program{
    static void GeraNumeros(int[] vetor){
        //gera números aleatórios
        Random numAleatorio = new Random();

        //.Length conta o tamanho do vetor
        for(int i = 0; i < vetor.Length; i++){
            vetor[i] = numAleatorio.Next(0, 1000); //números de 1 a 1000
        }

    }
    static void Main(){
        int[] vetor = new int[1000];

        GeraNumeros(vetor);    
        for(int i = 0; i < vetor.Length; i++){
            Console.Write(i + ": " + vetor[i] + "  ");
        }

        Console.WriteLine("\n");
        //função built-in de ordenação em forma crescente
        Array.Sort(vetor);

        for(int i = 0; i < vetor.Length; i++){
            Console.Write(i + ": " + vetor[i] + "  ");
        }
    }
}