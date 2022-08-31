using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("26 – Crie a função public Queue CopiaQueue(Queue<int> origem) que copia todos os dados do Queue<int> origem e retorna o novo Queue (não genérico) criado. ");
        Console.WriteLine(" ");
        Queue<int> Fila = new Queue<int>();
        for (int i = 0; i <= 10; i++)
        {
            Fila.Enqueue(i * 2);
        }
        Queue Fila2 = CopiaQueue(Fila);

        Console.WriteLine("Fila: ");
        foreach (int i in Fila2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }   
    public static Queue CopiaQueue(Queue<int> origem)
    {
        return new Queue(origem.ToArray());
    }
}