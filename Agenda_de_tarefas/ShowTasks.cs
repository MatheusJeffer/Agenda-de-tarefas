using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas
{
    public static class ShowTask
    {
        public static void ShowTasks(List<string> listname, string text)
        {
            //Essa função mostra para o usuário todo o contéudo da lista usando o foreach.
            //Contador para enumerar itens da lista.
            int contador = 0;
            //Pega a data atual do sistema
            DateTime data = DateTime.Now;

            if (listname.Count() >= 1)
            {
                Console.WriteLine($"{text}:");
                //Retira a hora, e deixa somente dia, mes, ano.
                Console.WriteLine($"Referente ao dia: {data.ToShortDateString()}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-");
                foreach (var item in listname)
                {
                    Console.WriteLine($"{contador}.{item}");
                    contador++;

                }
            }
            else
            {
                Console.WriteLine("Não tem nenhuma tarefa.");

            }
        }
    }
}
