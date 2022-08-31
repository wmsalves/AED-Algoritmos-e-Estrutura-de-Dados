using System;
using System.Collections;


class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("17 – Crie a função public Hashtable ConcatenaHashtable(Hashtable HT1, Hashtable HT2), o qual retorna um novo Hashtable contendo todos os elementos de HT1 e HT2. ");
        Console.WriteLine(" ");

        Hashtable HT1 = new Hashtable();
        Hashtable HT2 = new Hashtable();

        for (int i = 0; i < 5; i++)
        {
            HT1.Add(i, i * 2);
        }
        for (int i = 5; i < 5; i++)
        {
            HT2.Add(i, i * 2);
        }

        Hashtable HT3 = ConcatenaHashtable(HT1, HT2);

        foreach (DictionaryEntry de in HT3)
        {
            Console.WriteLine("Chave({0}) - Valor({1})", de.Key, de.Value);
        }
    }
    static public Hashtable ConcatenaHashtable(Hashtable HT1, Hashtable HT2)
    {
        Hashtable HT3 = new Hashtable();
        foreach (DictionaryEntry de in HT1)
        {
            HT3.Add(de.Key, de.Value);
        }
        foreach (DictionaryEntry de in HT2)
        {
            HT3.Add(de.Key, de.Value);
        }
        return HT3;
    }
}