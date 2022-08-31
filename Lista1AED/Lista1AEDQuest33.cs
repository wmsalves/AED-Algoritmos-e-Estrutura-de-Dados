using System;
using System.Collections;
using System.Collections.Generic;

class Program
{    public static void Main(string[] args)
    {
        Console.WriteLine("33 – Faça um programa que monte a estrutura abaixo usando Dictionary<> ou SortedList<>: ");
        Console.WriteLine(" ");

        long soma = 0;
        Dictionary<string, Dictionary<string, long>>
        Continente = new Dictionary<string, Dictionary<string, long>>();

        Continente.Add("América", new Dictionary<string, long>());
        Continente["América"].Add("Brasil", 202656784);
        Continente["América"].Add("Argentina", 45479120);
        Continente["América"].Add("Bolívia", 11639909);
        Continente["América"].Add("Chile", 18186770);
        Continente["América"].Add("Peru", 31914988);
        Continente["América"].Add("Paraguai", 7191685);

        Continente.Add("Ásia", new Dictionary<string, long>());
        Continente["Ásia"].Add("China", 1394016000);
        Continente["Ásia"].Add("Índia", 1326093184);
        Continente["Ásia"].Add("Egito", 104124440);
        Continente["Ásia"].Add("Afeganistão", 36643816);
        Continente["Ásia"].Add("Filipinas", 109180816);
        Continente["Ásia"].Add("Japão", 125507472);

        Continente.Add("Europa", new Dictionary<string, long>());
        Continente["Europa"].Add("França", 67848160);
        Continente["Europa"].Add("Itália", 62402660);
        Continente["Europa"].Add("Irlanda", 5176569);
        Continente["Europa"].Add("Espanha", 50015792);
        Continente["Europa"].Add("Portugal", 10302674);
        Continente["Europa"].Add("Alemanha", 80159664);

        foreach (KeyValuePair<string, Dictionary<string, long>> continente in Continente)
        {
            Console.WriteLine("Continente: " + continente.Key);

            foreach (KeyValuePair<string, long> pais in continente.Value)
            {
                Console.WriteLine("País: " + pais.Key);
                Console.WriteLine("População: " + pais.Value);
                soma += pais.Value;
            }
            Console.WriteLine("População Total do Continente: " + soma);
            Console.WriteLine("Pressiona uma tecla para informações sobre outro continente.");
            Console.WriteLine(" ");
            Console.ReadKey();
        }
    }
}