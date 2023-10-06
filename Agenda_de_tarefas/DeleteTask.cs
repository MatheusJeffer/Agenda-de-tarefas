using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas
{
    public static class DeleteTask
    {
      public static void delete()
        {
            //Aqui, esssa função vai ter a mesma funcionalidade dos outros case, a diferença vai ser o motivo de uso.
           ShowTask.ShowTasks(ListadeTarefas.TarefasnaoConcluidas, "Tarefas não concluídas.");
            Console.WriteLine("\nDigite um número correspodente a tarefa que vai ser apagada.");
            //Mesmo que o "case 3" a diferença que o usuário irá apagar o item, invés de marcá-lo como concluído.
            int deleteTarefa = int.Parse(Console.ReadLine());
            //Baseado no index, o item selecionado irá ser apagado.
            ListadeTarefas.TarefasnaoConcluidas.RemoveAt(deleteTarefa);
            Console.WriteLine("Tarefa excluída!");


        } 

    }
}
