using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("30 – Crie o procedimento public void InverteStack<T>(Stack<T> S) que inverte a ordem dos elementos do Stack<T> S, no próprio Stack. OBS1: nesse exercício você não deve utilizar o método reverse. ");
        Console.WriteLine(" ");

        Stack Pilha = new Stack();

        for (int i = 0; i < 10; i++)
        {
            Pilha.Push(i);
        }

        Console.WriteLine("======= Antes");
        foreach (int i in Pilha)
        {
            Console.WriteLine(i);
        }

        InverterStack(Pilha);

        Console.WriteLine("======= Depois");
        foreach (int i in Pilha)
        {
            Console.WriteLine(i);
        }
    }

    static public void InverterStack(Stack s)
    {
        Queue Fila = new Queue(s.Count);

        while (s.Count > 0)
        {
            Fila.Enqueue(s.Pop());
        }

        while (Fila.Count > 0)
        {
            s.Push(Fila.Dequeue());
        }
    }
}