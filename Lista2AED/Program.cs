using segundaLista;
using System;

class Program
{
    static void Main(string[] args)
    {
        CLista ListaAntes = new CLista();
        CLista ListaDepois = new CLista();
        CLista L1 = new CLista();
        CLista L2 = new CLista();
        CLista ListaConcatenada;
        CFila F1 = new CFila();
        CFila F2 = new CFila();
        CFila FilaConcatenada;
        CPilha P1 = new CPilha();
        CPilha P2 = new CPilha();
        CPilha PilhaConcatenada;

        // Questão 01
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Questões realizadas: 1 - 2 - 4 - 5 - 6");
        Console.WriteLine("Pressione qualquer tecla");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Questão 01");
        Console.WriteLine("Crie na CLista o método void InsereAntesDe(Object ElementoAInserir, Object Elemento) que insere o ElementoAInserir na posição anterior ao Elemento passado por parâmetro.");
        Console.ResetColor();
        Console.WriteLine("Digite o elemento a inserir: ");
        int ElementoAInserir = int.Parse(Console.ReadLine());
        Console.WriteLine("Dentre os números de 0 a 10, antes de qual elemento deseja inserir o numero informado? ");
        int Elemento = int.Parse(Console.ReadLine());
        Console.WriteLine("=======================================================================================");

        for (int i = 0; i <= 10; i++)
        {
            ListaAntes.InsereComeco(i);
        }

        ListaAntes.InsereAntesDe(ElementoAInserir, Elemento);

        foreach (Object item in ListaAntes)
        {
            Console.Write(item + " ");
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPressione qualquer tecla para avançar para próxima questão");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();
        
        // Questão 02
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Questão 02");
        Console.WriteLine("Crie na CLista o método void InsereDepoisDe(Object ElementoAInserir, Object Elemento) que insere o ElementoAInserir na posição anterior ao Elemento passado por parâmetro.");
        Console.ResetColor();
        Console.WriteLine("Digite o elemento a inserir: ");
        int ElementoAInserir2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Dentre os números de 0 a 10, depois de qual elemento deseja inserir o numero informado? ");
        int Elemento2 = int.Parse(Console.ReadLine());
        Console.WriteLine("========================================================================================");

        for (int i = 0; i <= 10; i++)
        {
            ListaDepois.InsereFim(i);
        }

        ListaDepois.InsereDepoisDe(ElementoAInserir2, Elemento2);

        foreach (Object item in ListaDepois)
        {
            Console.Write(item + " ");
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPressione qualquer tecla para avançar para próxima questão");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();
        
        // Questão 04
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Questão 04");
        Console.WriteLine("Crie a função CLista ConcatenaListas(CLista L1, CLista L2) que concatena as listas L1 e L2 passadas por parâmetro");
        Console.ResetColor();
        for (int i = 0; i <= 10; i++)
        {
            L1.InsereFim(i);
        }
        for (int i = 11; i <= 20; i++)
        {
            L2.InsereFim(i);
        }
        Console.WriteLine("Lista Concatenada: ");
        ListaConcatenada = L1.ConcatenaListas(L1,L2);
        foreach (Object item in ListaConcatenada)
        {
            Console.Write(item + " ");
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPressione qualquer tecla para avançar para próxima questão");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();

        // Questão 05
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Questão 05");
        Console.WriteLine("Crie  a  função  CFila  ConcatenaFila(CFila  F1,  CFila  F2)  que  concatena  as  filas  F1  e  F2  passadas  por  parâmetro.");
        Console.ResetColor();

        for (int i = 0; i <= 10; i++)
        {
            F1.Enfileira(i);
        }
        for (int i = 11; i <= 20; i++)
        {
            F2.Enfileira(i);
        }
        Console.WriteLine("Fila Concatenada: ");
        FilaConcatenada = F1.ConcatenaFila(F1,F2);
        foreach (Object item in FilaConcatenada)
        {
            Console.Write(item + " ");
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPressione qualquer tecla para avançar para próxima questão");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();

        // Questão 06
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Questão 06");
        Console.WriteLine("Crie a função CPilha ConcatenaPilha(CPilha P1, CPilha P2) que concatena as pilhas P1 e P2 passadas por parâmetro.");
        Console.ResetColor();

        for (int i = 0; i <= 10; i++)
        {
            P1.Empilha(i);
        }
        for(int i = 11; i <= 20; i++)
        {
            P2.Empilha(i);
        }
        Console.WriteLine("Pilha Concatenada: ");
        PilhaConcatenada = P1.ConcatenaPilha(P1,P2);
        foreach (Object item in PilhaConcatenada)
        {
            Console.Write(item + " ");
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nFim das Questões Realizadas");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();

    }
}
