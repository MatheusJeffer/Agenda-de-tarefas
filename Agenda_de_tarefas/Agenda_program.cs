using Agenda_de_Tarefas;
using System;
using System.Collections.Generic;

namespace Agenda_de_Tarefas
{
    public static class ListadeTarefas
    {
        public static List<string> TarefasnaoConcluidas = new List<string> { };
        public static List<string> TarefasConcluidas = new List<string> { };

        static void Main()
        {
            //Duas listas vão ser criadas, uma guarda tarefas que não foram concluídas, e a outra guarda tarefas concluídas.
            bool loopBreak = true;


            Console.WriteLine("Agendador de tarefas.");
            while (loopBreak)
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
                try
                {

                    switch (userInput)
                    {

                        case "1":
                            UserInputclass.Input("O que você vai fazer nessa tarefas?");
                            break;

                        case "2":
                            //Essa função irá ser chamada, e vai mostrar todo o conteúdo da lista selecionada.
                            ShowTask.ShowTasks(TarefasnaoConcluidas, "Tarefas não concluídas");
                            break;

                        case "3":
                            TaskMark.mark();
                            break;

                        case "4":
                            //Mesmo que o "case 2"
                            ShowTask.ShowTasks(TarefasConcluidas, "Tarefas concluídas.");
                            break;

                        case "5":
                            DeleteTask.delete();
                            break;

                        case "6":
                            EditTask.Edit();

                            break;

                        case "0":
                            Console.WriteLine("Saindo...");
                            loopBreak = false;
                            break;

                        default:
                            Console.WriteLine("ERROR: Opçãao inexistente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: APENAS NÚMEROS");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("ERROR: ÍNDICE INEXISTENTE.");
                }


            }
        }
    }
}