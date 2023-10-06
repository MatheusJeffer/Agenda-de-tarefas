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

                string userInput = OptionSelection.options();
                

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
                            TaskToMark.ToMark();
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
                catch (SystemException ex)
                {
                    Console.WriteLine($"ERROR:{ex}");

                }

            }
        }
    }
}