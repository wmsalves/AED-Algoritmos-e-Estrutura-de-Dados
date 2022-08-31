using System;
using System.Collections;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("10 – Crie a função public ArrayList OcorrenciasDe(ArrayList AL, Object elemento) o qual retorna um vetor contendo todas as posições que contem o elemento passado como parâmetro.");
        Console.WriteLine(" ");
        
        ArrayList al = new ArrayList();
        al.Add(20);
        al.Add(2);
        al.Add(3);
        al.Add(2);
        al.Add(7);
        al.Add(8);
        al.Add(9);
        al.Add(2);
        ArrayList posicoes = OcorrenciasDe(al, 2);
        Console.WriteLine("Mostrar ArrayList: ");
        foreach (object o in posicoes)
        {
            Console.WriteLine(o + " ");
        }
    }   
    static public ArrayList OcorrenciasDe(ArrayList al, Object elemento)
    {
        ArrayList posicoes = new ArrayList();
        for (int i = 0; i < al.Count; i++)
        {
            if (al[i].Equals(elemento))
            {
                posicoes.Add(i);
            }
        }
        return posicoes;
    }
}