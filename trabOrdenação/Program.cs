using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;


class Program
{
    // VETOR CRESCENTE //
    static int[] crescente(int tamanhovetor)
    {
        int[] vetor = new int[tamanhovetor];
        for (int d = 0; d < vetor.Length; d++)
        {
            vetor[d] = d;
        }
        return vetor;
    }

    // VETOR DECRESCENTE //
    static int[] decrescente(int tamanhovetor)
    {
        int[] vetor = new int[tamanhovetor];
        for (int f = 0; f < vetor.Length; f++)
        {
            vetor[f] = tamanhovetor;
            tamanhovetor = tamanhovetor - 1;
        }
        return vetor;
    }

    // VETOR RANDOM //
    static int[] aleatorio(int vetorinteiro)
    {
        int[] vetor = new int[vetorinteiro];
        Random aleatorio = new Random();
        for (int p = 0; p < vetor.Length; p++)
        {
            vetor[p] = aleatorio.Next(0, 10000);
        }
        return vetor;
    }


    // BUBBLE SORT //
    static int[] BubbleSort(int[] vetor)
    {
        int tamanho = vetor.Length;
        int comp = 0;
        int troca = 0;
        for (int i = tamanho - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                comp++;
                if (vetor[j] > vetor[j + 1])
                {
                    int aux = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = aux;
                    troca++;
                }
            }
        }

        return vetor;

    }


    // INSERTION SORT //
    void InsertionSort(int[] vetor, int tamanhoVetor)
    {
        int escolhido, j;
        for (int i = 1; i < tamanhoVetor; i++)
        {
            escolhido = vetor[i];
            j = i - 1;
            while ((j >= 0) && (vetor[j] > escolhido))
            {
                vetor[j + 1] = vetor[j];
                j--;
            }
            vetor[j + 1] = escolhido;
        }
    }

    // SELECTION SORT //
    static int[] SelectionSort(int[] vetor)
    {
        int min, aux;
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < vetor.Length; j++)
                if (vetor[j] < vetor[min])
                    min = j;
            if (min != i)
            {
                aux = vetor[min];
                vetor[min] = vetor[i];
                vetor[i] = aux;
            }
        }
        return vetor;
    }

    // QUICKSORT //
    static int[] QuickSort(int[] vetor)
    {
        int inicio = 0;
        int fim = vetor.Length - 1;
        QuickSort(vetor, inicio, fim);
        return vetor;
    }
    static void QuickSort(int[] vetor, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int p = vetor[inicio];
            int i = inicio + 1;
            int f = fim;
            while (i <= f)
            {
                if (vetor[i] <= p)
                {
                    i++;
                }
                else if (p < vetor[f])
                {
                    f--;
                }
                else
                {
                    int troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }
            vetor[inicio] = vetor[f];
            vetor[f] = p;
            QuickSort(vetor, inicio, f - 1);
            QuickSort(vetor, f + 1, fim);
        }
    }

    // MERGESORT //
    void Merge(int[] vetor, int inicio, int meio, int fim, int[] vetAux)
    {
        int lado1 = inicio;
        int lado2 = meio;
        for (int i = inicio; i < fim; ++i)
        {
            if ((lado1 < meio) && ((lado2 >= fim) || (vetor[lado1] < vetor[lado2])))
            {
                vetAux[i] = vetor[lado1];
                ++lado1;
            }
            else
            {
                vetAux[i] = vetor[lado2];
                ++lado2;
            }
        }

        for (int i = inicio; i < fim; ++i)
        {
            vetor[i] = vetAux[i];
        }
    }

    void MergeSort(int[] vetor, int inicio, int fim, int[] vetorAux)
    {
        if ((fim - inicio) < 2) return;

        int meio = ((inicio + fim) / 2);
        MergeSort(vetor, inicio, meio, vetorAux);
        MergeSort(vetor, meio, fim, vetorAux);
        Merge(vetor, inicio, meio, fim, vetorAux);
    }

    void MergeSort(int[] vetor, int tamanho)
    {
        int[] vetorAux = new int[tamanho];
        MergeSort(vetor, 0, tamanho, vetorAux);
    }


    static void Main(string[] args)
    {
        {

            // TEMPO EXECUÇÃO 3// 
            Stopwatch decrescentebubble = new Stopwatch();
            Stopwatch crescentebubble = new Stopwatch();
            Stopwatch aleatoriobubble = new Stopwatch();

            Stopwatch decrescenteinsertion = new Stopwatch();
            Stopwatch crescenteinsertion = new Stopwatch();
            Stopwatch aleatorioinsertion = new Stopwatch();

            Stopwatch decrescentequick = new Stopwatch();
            Stopwatch crescentequick = new Stopwatch();
            Stopwatch aleatorioquick = new Stopwatch();

            Stopwatch decrescenteselection = new Stopwatch();
            Stopwatch crescenteselection = new Stopwatch();
            Stopwatch aleatorioselection = new Stopwatch();

            Stopwatch decrescentemerge = new Stopwatch();
            Stopwatch crescentemerge = new Stopwatch();
            Stopwatch aleatoriomerge = new Stopwatch();


            // INSERTION SORT 1//

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("INSERTION SORT:");
            Console.ResetColor();


            // INSERTION SORT DECRESCENTE 8//
            int[] vetor_decrescente_insertion = new int[100000];
            vetor_decrescente_insertion = decrescente(100000);
            decrescenteinsertion.Start();

            // TEMPO 2//
            Program ordena_insertion = new Program();
            ordena_insertion.InsertionSort(vetor_decrescente_insertion, 100000);
            decrescenteinsertion.Stop();
            TimeSpan tempo_decrescente_insertion = decrescenteinsertion.Elapsed;

            // INSERTION SORT CRESCENTE 8//
            int[] vetor_crescente_insertion = new int[100000];
            vetor_crescente_insertion = crescente(100000);

            // TEMPO 9//
            Program ordena_crescente_insertion = new Program();
            ordena_crescente_insertion.InsertionSort(vetor_crescente_insertion, 100000);
            crescenteinsertion.Stop();
            TimeSpan tempo_crescente_insertion = crescenteinsertion.Elapsed;

            // INSERTION SORT RANDOM 1//
            int[] vetor_aleatorio_insertion = new int[100000];
            vetor_aleatorio_insertion = aleatorio(100000);

            // TEMPO 7// 
            aleatorioinsertion.Start();
            Program ordena_randon_insertion = new Program();
            ordena_randon_insertion.InsertionSort(vetor_aleatorio_insertion, 100000);
            aleatorioinsertion.Stop();
            TimeSpan tempo_aleatorio_insertion = aleatorioinsertion.Elapsed;

            Console.Write("\n Tempo de execução - vetor decrescente: " + tempo_decrescente_insertion);
            Console.Write("\n Tempo de execução - vetor crescente: " + tempo_crescente_insertion);
            Console.Write("\n Tempo de execução - vetor randomico: " + tempo_aleatorio_insertion);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nAperte ENTER para visualizar o Selection Sort");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();


            // SELECTION SORT //
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Selection sort: \n");
            Console.ResetColor();

            // SELECTION SORT DECRESCENTE //
            int[] vetor_decrescente_selection = new int[100000];
            vetor_decrescente_selection = decrescente(100000);

            // TEMPO //
            decrescenteinsertion.Start();
            SelectionSort(vetor_decrescente_selection);
            decrescenteselection.Stop();
            TimeSpan tempo_decrescente_selection = decrescenteselection.Elapsed;

            // SELECTION SORT CRESCENTE //          
            int[] vetor_crescente_selection = new int[100000];
            vetor_crescente_selection = crescente(100000);
            crescenteselection.Start();
            SelectionSort(vetor_crescente_selection);
            crescenteselection.Stop();
            TimeSpan tempo_crescente_selection = crescenteselection.Elapsed;

            // SELECTION SORT RANDOM //
            int[] vetor_aleatorio_selection = new int[100000];
            vetor_aleatorio_selection = aleatorio(100000);

            //TEMPO//
            aleatorioselection.Start();
            SelectionSort(vetor_aleatorio_selection);

            aleatorioselection.Stop();
            TimeSpan tempo_aleatorio_selection = aleatorioselection.Elapsed;


            Console.WriteLine();
            Console.Write("\n Tempo de execução - vetor decrescente: " + tempo_decrescente_selection);
            Console.Write("\n Tempo de execução - vetor crescente: " + tempo_crescente_selection);
            Console.Write("\n Tempo de execução - vetor randomico: " + tempo_aleatorio_selection);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nAperte ENTER para visualizar o Bubble Sort");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();


            // BUBBLE SORT //
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Bubble sort: \n");
            Console.ResetColor();

            // BUBBLE SORT DECRESCENTE //
            int[] vetor_decrescente_bubble = new int[100000];
            vetor_decrescente_bubble = decrescente(100000);

            // TEMPO //
            decrescentebubble.Start();
            SelectionSort(vetor_decrescente_bubble);
            decrescentebubble.Stop();
            TimeSpan tempo_decrescente_bubble = decrescentebubble.Elapsed;

            // BUBBLE SORT CRESCENTE //
            int[] vetor_crescente_bubble = new int[100000];
            vetor_crescente_bubble = crescente(100000);

            // TEMPO //
            crescentebubble.Start();
            BubbleSort(vetor_crescente_bubble);
            crescentebubble.Stop();
            TimeSpan tempo_crescente_bubble = crescentebubble.Elapsed;

            // BUBBLE SORT RANDON //
            int[] vetor_aleatorio_bubble = new int[100000];
            vetor_aleatorio_bubble = aleatorio(100000);

            // TEMPO //
            aleatoriobubble.Start();
            BubbleSort(vetor_aleatorio_bubble);
            aleatoriobubble.Stop();
            TimeSpan tempo_aleatorio_bubble = aleatoriobubble.Elapsed;

            Console.WriteLine();
            Console.Write("\n Tempo de execução - vetor decrescente: " + tempo_decrescente_bubble);
            Console.Write("\n Tempo de execução - vetor crescente: " + tempo_crescente_bubble);
            Console.Write("\n Tempo de execução - vetor randomico: " + tempo_aleatorio_bubble);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nAperte ENTER para visualizar o Quick Sort");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();


            // QUICK SORT //
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Quick Sort: \n");
            Console.ResetColor();

            // QUICK SORT DECRESCENTE //
            int[] vetor_decrescente_quick = new int[100000];
            vetor_decrescente_quick = decrescente(100000);

            // TEMPO //
            decrescentequick.Start();
            QuickSort(vetor_decrescente_quick);
            decrescentequick.Stop();
            TimeSpan tempo_decrescente_quick = decrescentequick.Elapsed;

            // QUICK SORT CRESCENTE //
            int[] vetor_cres_quick = new int[100000];
            vetor_cres_quick = crescente(100000);

            // TEMPO //
            crescentequick.Start();
            QuickSort(vetor_cres_quick);
            crescentequick.Stop();
            TimeSpan tempo_crescente_quick = crescentequick.Elapsed;

            // QUICK SORT RANDOM //
            int[] vetor_randon_quick = new int[100000];
            vetor_randon_quick = aleatorio(100000);

            // TEMPO //
            aleatorioquick.Start();
            QuickSort(vetor_randon_quick);
            aleatorioquick.Stop();
            TimeSpan tempo_aleatorio_quick = aleatorioquick.Elapsed;

            Console.Write("\n Tempo de execução - vetor decrescente: " + tempo_decrescente_quick);
            Console.Write("\n Tempo de execução - vetor crescente: " + tempo_crescente_quick);
            Console.Write("\n Tempo de execução - vetor randomico: " + tempo_aleatorio_quick);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nAperte ENTER para visualizar o Merge Sort");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();


            // MERGE SORT //
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Merge Sort: \n");
            Console.ResetColor();

            // MERGE SORT DECRESCENTE //
            int[] vetor_decrescente_merge = new int[100000];
            vetor_decrescente_merge = decrescente(100000);

            // TEMPO // 
            decrescentemerge.Start();
            Program ordena_merge = new Program();
            ordena_merge.MergeSort(vetor_decrescente_merge, 100000);
            decrescentemerge.Stop();
            TimeSpan tempo_decrescente_merge = decrescentemerge.Elapsed;

            // MERGE SORT CRESCENTE //
            int[] vetor_crescente_merge = new int[100000];
            vetor_crescente_merge = crescente(100000);

            // TEMPO //
            crescentemerge.Start();
            Program ordena_cres_merge = new Program();
            ordena_cres_merge.MergeSort(vetor_crescente_merge, 100000);
            crescentemerge.Stop();
            TimeSpan tempo_crescente_merge = crescentemerge.Elapsed;

            // MERGE SORT RANDOM //
            int[] vetor_randon_merge = new int[100000];
            vetor_randon_merge = aleatorio(100000);

            // TEMPO //
            aleatoriomerge.Start();
            Program ordena_randon_merge = new Program();
            ordena_randon_merge.MergeSort(vetor_randon_merge, 100000);
            aleatoriomerge.Stop();
            TimeSpan tempo_aleatorio_merge = aleatoriomerge.Elapsed;


            Console.Write("\n Tempo de execução - vetor decrescente: " + tempo_decrescente_merge);
            Console.Write("\n Tempo de execução - vetor crescente: " + tempo_crescente_merge);
            Console.Write("\n Tempo de execução - vetor randomico: " + tempo_aleatorio_merge);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nSAIR");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();

        }
    }
}