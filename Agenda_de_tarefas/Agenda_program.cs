using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
class ListadeTarefas
{ 
    static void listinterations(List<string> listname, string text)
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

    static void Main()
    {
        //Duas listas vão ser criadas, uma guarda tarefas que não foram concluídas, e a outra guarda tarefas concluídas.
        List<string> tarefasnaoConcluidas = new List<string> { };
        List<string> tarefasConcluidas = new List<string> { };


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

            Console.Write("O que você quer escrever? ");
            //Entrada do usuário, onde ele vai escolher uma das opções mostradas no console.
            string userInput = Console.ReadLine();
            Console.WriteLine("-=-=-=-=-==-=-=-=-==-=-=-=-=-=-==-=-=-=");

            //Esse switch recebe o que o usuário digitar.
            switch (userInput)
            {

                case "1":
                    
                    Console.WriteLine("Digite o que voce vai fazer nessa tarefa:");
                    string tarefaInput = Console.ReadLine();

                    //Esse loop vai ser executado quando o usuário digitar pouco ou muitos caracteres.
                    while (tarefaInput.Length > 50 || tarefaInput.Length < 4)
                    {
                        Console.WriteLine("Error: Digite pelo menos 4 ou 20 caractes");
                        tarefaInput = Console.ReadLine();
                        Console.WriteLine("-=-=-=-=-==-=-=-=-==-=-=-=-=-=-==-=-=-=");

                    }

                    //A tarefa que usuário digitou será enviada e adicionada na lista abaixo.
                    tarefasnaoConcluidas.Add(tarefaInput);
                    Console.WriteLine("Tarefa adicionada!");
                    
                    break;

                case "2":

                    //Essa função irá ser chamada, e vai mostrar todo o conteúdo da lista selecionada.
                    listinterations(tarefasnaoConcluidas, "Tarefas não concluídas.");
                   
                    break;

                case "3":

                    //O mesmo do que o "case 2", mas aqui a funcionalidade dessa função vai ser diferente.
                    listinterations(tarefasnaoConcluidas, "Tarefas não concluídas.");
                    Console.WriteLine("Digite um número o da tarefa que que concluir.");
                   
                    try
                    {
                        //O usuário pode escolher qual tarefa vai ser marcada como "concluída" a partir da enumerações.
                        int tarefasconcluidasinput = int.Parse(Console.ReadLine());
                        
                        //Após o usuário escolher, a tarefa que o usuário irá ser adicionada aqui, baseada no index da outra lista.
                        tarefasConcluidas.Add(tarefasnaoConcluidas[tarefasconcluidasinput]);
                        
                        //Após isso, o item selecionado, ai ser exclúido da lista, baseado na enumerações.
                        tarefasnaoConcluidas.RemoveAt(tarefasconcluidasinput);
                        Console.WriteLine("Tarefa marcada como concluída com sucesso!");
                    }

                    catch (FormatException)
                    {

                        Console.WriteLine("ERROR: DIGITE APENAS NÚMEROS.");

                    }
                    
                    catch (ArgumentOutOfRangeException)
                    {

                        Console.WriteLine("ERROR: ÍNDICE INEXISTENTE.");

                    }

                    break;

                case "4":

                    //Mesmo que o "case 2"
                    listinterations(tarefasConcluidas, "Tarefas concluídas.");
                    
                    break;

                case "5":

                    //Aqui, esssa função vai ter a mesma funcionalidade dos outros case, a diferença vai ser o motivo de uso.
                    listinterations(tarefasnaoConcluidas, "Tarefas não concluídas.");

                    Console.WriteLine("\nDigite um número correspodente a tarefa que vai ser apagada.");
                    //Mesmo que o "case 3" a diferença que o usuário irá apagar o item, invés de marcá-lo como concluído.
                    try
                    {
                        int deleteTarefa = int.Parse(Console.ReadLine());
                        //Baseado no index, o item selecionado irá ser apagado.
                        tarefasnaoConcluidas.RemoveAt(deleteTarefa);
                        Console.WriteLine("Tarefa excluída!");
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("ERROR: DIGITE APENAS NÚMEROS INTEIROS.");

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("ERROR: ÍNDICE INEXISTENTE.");

                    }
                    
                    break;
                case "6":

                    //A mesma coisa que ocorre nos outros cases.
                    listinterations(tarefasnaoConcluidas, "Tarefas não concluídas");
                    Console.WriteLine("Escolha a tarefa que quer editar");
                    //O usuário pode escolher qual tarefa vai editar com enumerações. 
                    try
                    {
                        int chooseinput = int.Parse(Console.ReadLine());
                        Console.WriteLine("Agora digite novamente a tarefa com as alterações: ");
                        //Após o usuário escolher a tarefa, ele poderá edita-lá.
                        tarefaInput = Console.ReadLine();
                        //Baseado no indice da lista, a tarefa vai ser substituída.
                        tarefasnaoConcluidas[chooseinput] = tarefaInput;
                        Console.WriteLine("Tarefa editada!");

                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("ERROR: DIGITE APENAS NÚMEROS INTEIROS.");
                    }
                    
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("ERROR: ÍNDICE INEXISTENTE.");
                    }

                    break;

                case "0":

                    Console.WriteLine("Saindo...");
                    
                    break;

                default:
                    Console.WriteLine("ERROR: Opçãao inexistente.");
                    break;
            }

            if (userInput == "0")
            {
                break;
            }

        }
    }
}