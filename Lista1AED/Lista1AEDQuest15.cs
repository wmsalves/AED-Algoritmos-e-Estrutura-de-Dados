using System;
using System.Collections;


class Program
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("15 – Crie o procedimento public void InverteQueue(Queue Q) que inverte a ordem dos elementos do Queue Q, no próprio Queue. OBS1: utilize outras estruturas - vetor, ArrayList, Stack ou mesmo outro Queue – que julgar necessárias. OBS2: nesse exercício você não deve utilizar o método reverse. ");
        Console.WriteLine(" ");

        Queue fila = new Queue();

        for (int i = 0; i < 10; i++)
        {
            fila.Enqueue(i);
        }

        Console.Write("Antes: ");
        foreach (int i in fila)
        {
            Console.Write(i + " ");
        }

        InverterQueue(fila);

        Console.WriteLine(" ");
        Console.Write("Depois: ");
        foreach (int i in fila)
        {
            Console.Write(i + " ");
        }
    }
    static public void InverterQueue(Queue q)
    {
        Stack pilha = new Stack(q.Count);

        while (q.Count > 0)
        {
            pilha.Push(q.Dequeue());
        }

        while (pilha.Count > 0)
        {
            q.Enqueue(pilha.Pop());
        }
    }
}