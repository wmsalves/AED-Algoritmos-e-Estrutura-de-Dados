using System;
using System.Collections;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("12 – Crie a função public Queue CopiaQueue(Queue origem) a qual retorna uma cópia da Queue origem passada como parâmetro. Os elementos da Queue origem devem permacer na mesma ordem original. Atenção: não é permitido usar os métodos Clone() e CopyTo() da classe Queue. ");
        Console.WriteLine(" ");

        Queue origem = new Queue();
        for (int i = 0; i < 5; i++)
        {
            origem.Enqueue(i);
        }

        ArrayList AL = CopiarQueueParaArrayList(origem);

        foreach (int i in AL)
        {
            Console.WriteLine(i);
        }
    }
    static public ArrayList CopiarQueueParaArrayList(Queue origem)
    {
        ArrayList copia = new ArrayList(origem.Count);
        for (int i = 0; i < origem.Count; i++)
        {
            copia.Add(origem.Peek());
            origem.Enqueue(origem.Dequeue());
        }
        return copia;
    }
}