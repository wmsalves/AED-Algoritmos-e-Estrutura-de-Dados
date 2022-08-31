using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("22 - Faça um programa que cadastre em um Hashtable alguns modelos de carros de montadoras nacionais, conforme a tabela abaixo (você deve fazer esse cadastro internamente, não o usuário – crie uma função para isso). Seu Hashtable tem como chave o nome da montadora, e como valor um Arraylist contendo os modelos de carros da tabela abaixo. Após o cadastro, peça ao usuário que digite o nome de uma montadora. Você deve imprimir a quantidade de modelos e nome de cada um");
        Console.WriteLine(" ");

        string Marca;
        Hashtable Montadora = new Hashtable();

        Montadora.Add("Fiat", new ArrayList());

        ((ArrayList)Montadora["Fiat"]).Add("Mille");
        ((ArrayList)Montadora["Fiat"]).Add("Novo Uno");
        ((ArrayList)Montadora["Fiat"]).Add("Palio");
        ((ArrayList)Montadora["Fiat"]).Add("Siena");
        ((ArrayList)Montadora["Fiat"]).Add("Freemont");
        ((ArrayList)Montadora["Fiat"]).Add("Bravo");
        ((ArrayList)Montadora["Fiat"]).Add("Punto");
        ((ArrayList)Montadora["Fiat"]).Add("Linea");
        ((ArrayList)Montadora["Fiat"]).Add("Palio Weekend");

        Montadora.Add("Volkswagen", new ArrayList());

        ((ArrayList)Montadora["Volkswagen"]).Add("Gol");
        ((ArrayList)Montadora["Volkswagen"]).Add("Voyage");
        ((ArrayList)Montadora["Volkswagen"]).Add("Polo");
        ((ArrayList)Montadora["Volkswagen"]).Add("Passat");
        ((ArrayList)Montadora["Volkswagen"]).Add("Amarok");
        ((ArrayList)Montadora["Volkswagen"]).Add("Fox");
        ((ArrayList)Montadora["Volkswagen"]).Add("Golf");
        ((ArrayList)Montadora["Volkswagen"]).Add("Jetta");
        ((ArrayList)Montadora["Volkswagen"]).Add("Tiguan");

        Montadora.Add("Ford", new ArrayList());

        ((ArrayList)Montadora["Ford"]).Add("Focus");
        ((ArrayList)Montadora["Ford"]).Add("Fiesta");
        ((ArrayList)Montadora["Ford"]).Add("Ka");
        ((ArrayList)Montadora["Ford"]).Add("New Fiesta");
        ((ArrayList)Montadora["Ford"]).Add("Fusion");
        ((ArrayList)Montadora["Ford"]).Add("Edge");

        Montadora.Add("GM", new ArrayList());

        ((ArrayList)Montadora["GM"]).Add("Celta");
        ((ArrayList)Montadora["GM"]).Add("Classic");
        ((ArrayList)Montadora["GM"]).Add("Prisma");
        ((ArrayList)Montadora["GM"]).Add("Agile");
        ((ArrayList)Montadora["GM"]).Add("Omega");
        ((ArrayList)Montadora["GM"]).Add("Cruze");
        ((ArrayList)Montadora["GM"]).Add("Camaro");
        ((ArrayList)Montadora["GM"]).Add("Malibu");

        try
        {
            Console.WriteLine("Digite o nome da montadora que deseja pesquisar: Fiat, Volkswagen, Ford ou GM");
            Marca = Console.ReadLine();
            Console.WriteLine();
            int i = 0;

            foreach (string carros in (ArrayList)Montadora[Marca])
            {
                if (Montadora.ContainsKey(Marca))
                {
                    Console.WriteLine((i + 1) + "º carro cadastrado: " + carros);
                    i = i + 1;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Total de carros cadastrados: " + i);
        }
        catch
        {
            Console.WriteLine("Montadora não cadastrada no sistema");
        }
    }
}