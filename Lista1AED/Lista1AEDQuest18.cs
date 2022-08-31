using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("18 – Um biólogo precisa de um programa que traduza uma trinca de nucleotídeos em seu aminoácido correspondente. Por exemplo, a trinca de aminoácidos ACG é traduzida como o aminoácido Treonina, e GCA em Alanina. Crie um programa em C# que use um Hashtable para criar um dicionário do código genético. O usuário deve digitar uma trinca (chave) e seu programa deve mostrar o nome (valor) do aminoácido correspondente. Use a tabela abaixo para cadastrar todas as trincas/aminoácidos. ");
        Console.WriteLine(" ");

        string trinca;
        Hashtable Aminoacidos = new Hashtable();

        Aminoacidos.Add("UUU", "Fenilalanina");
        Aminoacidos.Add("UUC", "Fenilalanina");
        Aminoacidos.Add("UUA", "Leucina");
        Aminoacidos.Add("UUG", "Leucina");
        Aminoacidos.Add("UCU", "Serina");
        Aminoacidos.Add("UCC", "Serina");
        Aminoacidos.Add("UCA", "Serina");
        Aminoacidos.Add("UCG", "Serina");
        Aminoacidos.Add("UAU", "Tirosina");
        Aminoacidos.Add("UAC", "Tirosina");
        Aminoacidos.Add("UAA", "Parada");
        Aminoacidos.Add("UAG", "Parada");
        Aminoacidos.Add("UGU", "Cisteina");
        Aminoacidos.Add("UGC", "Cisteina");
        Aminoacidos.Add("UGA", "Parada");
        Aminoacidos.Add("UGG", "Triptofano");
        Aminoacidos.Add("CUU", "Leucina");
        Aminoacidos.Add("CUC", "Leucina");
        Aminoacidos.Add("CUA", "Leucina");
        Aminoacidos.Add("CUG", "Leucina");
        Aminoacidos.Add("CCU", "Prolina");
        Aminoacidos.Add("CCC", "Prolina");
        Aminoacidos.Add("CCA", "Prolina");
        Aminoacidos.Add("CCG", "Prolina");
        Aminoacidos.Add("CAU", "Histidina");
        Aminoacidos.Add("CAC", "Histidina");
        Aminoacidos.Add("CAA", "Glutamina");
        Aminoacidos.Add("CAG", "Glutamina");
        Aminoacidos.Add("CGU", "Arginima");
        Aminoacidos.Add("CGC", "Arginina");
        Aminoacidos.Add("CGA", "Arginina");
        Aminoacidos.Add("CGG", "Arginina");
        Aminoacidos.Add("AUU", "Isoleucina");
        Aminoacidos.Add("AUC", "Isoleucina");
        Aminoacidos.Add("AUA", "Isoleucina");
        Aminoacidos.Add("AUG", "Metionina");
        Aminoacidos.Add("ACU", "Treonina");
        Aminoacidos.Add("ACC", "Treonina");
        Aminoacidos.Add("ACA", "Treonina");
        Aminoacidos.Add("ACG", "Treonina");
        Aminoacidos.Add("AAU", "Asparagina");
        Aminoacidos.Add("AAC", "Asparagina");
        Aminoacidos.Add("AAA", "Lisina");
        Aminoacidos.Add("AAG", "Lisina");
        Aminoacidos.Add("AGU", "Serina");
        Aminoacidos.Add("AGC", "Serina");
        Aminoacidos.Add("AGA", "Arginina");
        Aminoacidos.Add("AGG", "Arginina");
        Aminoacidos.Add("GUU", "Valina");
        Aminoacidos.Add("GUC", "Valina");
        Aminoacidos.Add("GUA", "Valina");
        Aminoacidos.Add("GUG", "Valina");
        Aminoacidos.Add("GCU", "Alanina");
        Aminoacidos.Add("GCC", "Alanina");
        Aminoacidos.Add("GCA", "Alanina");
        Aminoacidos.Add("GCG", "Alanina");
        Aminoacidos.Add("GAU", "Aspartato");
        Aminoacidos.Add("GAC", "Aspartato");
        Aminoacidos.Add("GAA", "Glutamato");
        Aminoacidos.Add("GAG", "Glutamato");
        Aminoacidos.Add("GGU", "Glicina");
        Aminoacidos.Add("GGC", "Glicina");
        Aminoacidos.Add("GGA", "Glicina");
        Aminoacidos.Add("GGG", "Glicina");


        Console.Write("Digite a trinca de aminoácidos que deseja verificar: ");
        trinca = Console.ReadLine();

        foreach (DictionaryEntry nucleo in Aminoacidos)
        {
            if (trinca.Equals((string)nucleo.Key))
            {
                Console.WriteLine("A trinca de aminoácido pesquisado é: " + nucleo.Value);
            }
        }
    }
}