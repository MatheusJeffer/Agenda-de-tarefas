using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas
{
    public static class UserInputclass
    {
        public static void Input(string text)
        {
            Console.WriteLine($"{text}");
            string tarefaInput;
            tarefaInput = Console.ReadLine();

            tarefaInput.TrimEnd().TrimStart();

            //Esse loop vai ser executado quando o usuário digitar pouco ou muitos caracteres.
            if (text != "Selecione uma opção:")
            {
                while (tarefaInput.Length > 50 || tarefaInput.Length < 4)
                {
                    Console.WriteLine("Error: Digite pelo menos 4 ou 20 caractes");
                    tarefaInput = Console.ReadLine();
                    Console.WriteLine("-=-=-=-=-==-=-=-=-==-=-=-=-=-=-==-=-=-=");
                }
            }
            ListadeTarefas.TarefasnaoConcluidas.Add(tarefaInput);
            Console.WriteLine("Tarefa adicionada!");
        }
    }
}