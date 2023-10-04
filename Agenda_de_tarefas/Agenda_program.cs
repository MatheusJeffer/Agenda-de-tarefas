using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

internal class ListadeTarefas
{ 

    static void Main()
    {
        //Duas listas vão ser criadas, uma guarda tarefas que não foram concluídas, e a outra guarda tarefas concluídas.
        List<string> tarefasnaoConcluidas = new List<string> { };
        List<string> tarefasConcluidas = new List<string> { };

        List_function list_functions = new List_function();
        userInput userInputclass = new userInput();


        Console.WriteLine("Agendador de tarefas.");
        while (true)
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
            string userInput = userInputclass.userInputFunction("Selecione uma opção:");
            Console.WriteLine("-=-=-=-=-==-=-=-=-==-=-=-=-=-=-==-=-=-=");

            //Esse switch recebe o que o usuário digitar.
            try
            {
                switch (userInput)
                {

                    case "1":
                        //A tarefa que usuário digitou será enviada e adicionada na lista abaixo.
                        tarefasnaoConcluidas.Add(userInputclass.userInputFunction("O que você vai fazer nessa tarefa?"));
                        Console.WriteLine("Tarefa adicionada!");
                        break;

                    case "2":
                        //Essa função irá ser chamada, e vai mostrar todo o conteúdo da lista selecionada.
                        list_functions.listinterations(tarefasnaoConcluidas, "Tarefas não concluídas");
                        break;

                    case "3":
                        //O mesmo do que o "case 2", mas aqui a funcionalidade dessa função vai ser diferente.
                         list_functions.listinterations(tarefasnaoConcluidas, "Tarefas não concluídas.");
                        Console.WriteLine("Digite um número o da tarefa que que concluir.");
                        //O usuário pode escolher qual tarefa vai ser marcada como "concluída" a partir da enumerações.
                        int tarefasconcluidasinput = int.Parse(Console.ReadLine());
                        //Após o usuário escolher, a tarefa que o usuário irá ser adicionada aqui, baseada no index da outra lista.
                        tarefasConcluidas.Add(tarefasnaoConcluidas[tarefasconcluidasinput]);
                        //Após isso, o item selecionado, ai ser exclúido da lista, baseado na enumerações.
                        tarefasnaoConcluidas.RemoveAt(tarefasconcluidasinput);
                        Console.WriteLine("Tarefa marcada como concluída com sucesso!");
                        break;

                    case "4":
                        //Mesmo que o "case 2"
                        list_functions.listinterations(tarefasConcluidas, "Tarefas concluídas.");
                        break;

                    case "5":
                        //Aqui, esssa função vai ter a mesma funcionalidade dos outros case, a diferença vai ser o motivo de uso.
                        list_functions.listinterations(tarefasnaoConcluidas, "Tarefas não concluídas.");
                        Console.WriteLine("\nDigite um número correspodente a tarefa que vai ser apagada.");
                        //Mesmo que o "case 3" a diferença que o usuário irá apagar o item, invés de marcá-lo como concluído.
                        int deleteTarefa = int.Parse(Console.ReadLine());
                        //Baseado no index, o item selecionado irá ser apagado.
                        tarefasnaoConcluidas.RemoveAt(deleteTarefa);
                        Console.WriteLine("Tarefa excluída!");
                        break;

                    case "6":
                        //A mesma coisa que ocorre nos outros cases.
                        list_functions.listinterations(tarefasnaoConcluidas, "Tarefas não concluídas");
                        Console.WriteLine("Escolha a tarefa que quer editar");
                        //O usuário pode escolher qual tarefa vai editar com enumerações. 
                        int chooseinput = int.Parse(Console.ReadLine());
                        Console.WriteLine("Agora digite novamente a tarefa com as alterações: ");
                        //Após o usuário escolher a tarefa, ele poderá edita-lá.
                        string taskedit = userInputclass.userInputFunction("O que você vai fazer nessa tarefa?");
                        //Baseado no indice da lista, a tarefa vai ser substituída.
                        tarefasnaoConcluidas[chooseinput] = taskedit;
                        Console.WriteLine("Tarefa editada!");
                        break;

                    case "0":
                        Console.WriteLine("Saindo...");
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

            if (userInput == "0")
            {
                break;
            }

        }
    }
}