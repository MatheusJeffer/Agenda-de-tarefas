using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas
{
    public static class TaskToMark
    {
        public static void ToMark()
        {
            //O mesmo do que o "case 2", mas aqui a funcionalidade dessa função vai ser diferente.
            ShowTask.ShowTasks(ListadeTarefas.TarefasnaoConcluidas, "Tarefas não concluídas.");
            Console.WriteLine("Digite um número o da tarefa que que concluir.");
            //O usuário pode escolher qual tarefa vai ser marcada como "concluída" a partir da enumerações.
            int tarefasconcluidasinput = int.Parse(Console.ReadLine());
            //Após o usuário escolher, a tarefa que o usuário irá ser adicionada aqui, baseada no index da outra lista.
            ListadeTarefas.TarefasConcluidas.Add(ListadeTarefas.TarefasnaoConcluidas[tarefasconcluidasinput]);
            //Após isso, o item selecionado, ai ser exclúido da lista, baseado na enumerações.
            ListadeTarefas.TarefasnaoConcluidas.RemoveAt(tarefasconcluidasinput);
            Console.WriteLine("Tarefa marcada como concluída com sucesso!");


        }

    }
}
