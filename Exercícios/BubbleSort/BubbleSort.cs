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
    static void BubbleSort(int[] vetor){
        int temp = 0;
        bool troca = false;
        do{
            troca = false;
            for(int i = 0; i < vetor.Length - 1; i++){
                if(vetor[i] > vetor[i + 1]){
                    troca = true;
                    temp = vetor[i];
                    vetor[i] = vetor[i+1];
                    vetor[i+1] = temp;
                }
            }
        }while(troca == true);

        //bubble sort que faz a comparação mesmo que já esteja ordenado
        /*for(int i = 0; i < vetor.Length; i++){
            for(int j = 0; j < vetor.Length - 1; j++){
                if(vetor[j] > vetor[j + 1]){
                    temp = vetor[j];
                    vetor[j] = vetor[j+1];
                    vetor[j+1] = temp;
                }
            }
        }*/
    }

    static void Main(){
        int[] vetor = new int[1000];

        GeraNumeros(vetor);    
        for(int i = 0; i < vetor.Length; i++){
            Console.Write(i + ": " + vetor[i] + "  ");
        }

        Console.WriteLine("\n");
        BubbleSort(vetor);

        for(int i = 0; i < vetor.Length; i++){
            Console.Write(i + ": " + vetor[i] + "  ");
        }
    }
}