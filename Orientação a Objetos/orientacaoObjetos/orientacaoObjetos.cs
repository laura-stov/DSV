//

using System;

class Program{
    public class Tarefa{
        public string Titulo {get; set;}
        public string Descricao {get; set;}
        public bool Conluida {get; set;}

        public Tarefa(string titulo, string descricao){
            Titulo = titulo;
            Descricao = descricao;
            Conluida = false; 
        }

        public void MarcarComoConcluida(){
            Conluida = true;
        }
    }

    public class ListaDeTarefas{
        List<Tarefa> tarefas = new List<Tarefa>();

        public void AdicionarTarefa(Tarefa tarefa){
            tarefas.Add(tarefa);
        }

        public void RemoverTarefa(Tarefa tarefa){
            tarefas.Remove(tarefa);
        }

        public void ListarTarefas(){
            foreach(var tarefa in tarefas){
                Console.WriteLine($"Título: {tarefa.Titulo}, Descricao: {tarefa.Descricao}, Concluida: {tarefa.Conluida}.");
            }
        }
    }

    static void Main(string[] args){
        Console.WriteLine("Digite o título da sua tarefa, e em seguida, digite a descrição da mesma.");
        Tarefa tarefa1 = new Tarefa(Console.ReadLine(), Console.ReadLine());

        Console.WriteLine("\nDigite o título da sua tarefa, e em seguida, digite a descrição da mesma.");
        Tarefa tarefa2 = new Tarefa(Console.ReadLine(), Console.ReadLine());
        
        ListaDeTarefas listaDeTarefas = new ListaDeTarefas();
        listaDeTarefas.AdicionarTarefa(tarefa1);
        listaDeTarefas.AdicionarTarefa(tarefa2);

        Console.WriteLine("\nMostrando lista de tarefas:");
        listaDeTarefas.ListarTarefas();
        tarefa1.MarcarComoConcluida();
        listaDeTarefas.RemoverTarefa(tarefa2);
        Console.WriteLine("\nMostrando lista de tarefas:");
        listaDeTarefas.ListarTarefas();        
    }
}

