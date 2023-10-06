using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda_de_Tarefas;


namespace Agenda_de_Tarefas
{
    public static class OptionSelection
    {
        public static string options()
        {
            Console.WriteLine("-=-=-=-=-==-=-=-=-==-=-=-=-=-=-==-=-=-=");
            Console.Write(
                "O que você quer fazer?\n[1]Criar uma nova tarefa\n" +
                "[2]Ver todas as tarefas não concluidas\n" +
                "[3]Concluir uma tarefa.\n" +
                "[4]Ver todas as tarefas concluidas tarefa.\n" +
                "[5]Excluir uma tarefa.\n" +
                "[6]Editar Tarefa.\n" +
                "[0]Sair.\n"
                );
            Console.WriteLine("-=-=-=-=-==-=-=-=-==-=-=-=-=-=-==-=-=-=");
            //Entrada do usuário, onde ele vai escolher uma das opções mostradas no console.
            Console.WriteLine("Selecione a opção:");
            string userInput = Convert.ToString(Console.ReadLine());
            Console.WriteLine("-=-=-=-=-==-=-=-=-==-=-=-=-=-=-==-=-=-=");
            //Esse switch recebe o que o usuário digitar.
            return userInput;


        }
    }
}
