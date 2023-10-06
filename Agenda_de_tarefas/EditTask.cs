using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas
{
    public static class EditTask
    {
        public static void Edit()
        {
            //A mesma coisa que ocorre nos outros cases.
            ShowTask.ShowTasks(ListadeTarefas.TarefasnaoConcluidas, "Tarefas não concluídas");
            Console.WriteLine("Escolha a tarefa que quer editar");
            //O usuário pode escolher qual tarefa vai editar com enumerações. 
            int chooseinput = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite novamente a tarefa com as alterações: ");
            //Após o usuário escolher a tarefa, ele poderá edita-lá.
            string taskedit = Convert.ToString(Console.ReadLine());
            //Baseado no indice da lista, a tarefa vai ser substituída.
            ListadeTarefas.TarefasnaoConcluidas[chooseinput] = taskedit;
            Console.WriteLine("Tarefa editada!");
        }
    }
}
