using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("23 – Refaça o exercício 19 usando a coleção genérica Dictionary");
        Console.WriteLine(" ");

        string url;
        Dictionary<string, string> URL = new Dictionary<string, string>();

        URL.Add("www.google.com", "142.251.129.228");
        URL.Add("www.twitter.com", "104.244.42.129");
        URL.Add("www.gmail.com", "172.217.30.165");
        URL.Add("www.facebook.com", "157.240.12.35");
        URL.Add("www.twitch.tv", "199.232.114.167");
        URL.Add("www.replit.com", "104.18.13.38]");
        URL.Add("www.instagram.com", "157.240.12.174]");
        URL.Add("www.pucminas.br", "200.229.32.29");
        URL.Add("www.binance.com", "13.33.108.41");
        URL.Add("www.steamcommunity.com", "23.42.251.154");


        Console.WriteLine("Digite a URL que deseja pesquisar: ");
        url = Console.ReadLine();

        if (URL.ContainsKey(url))
        {
            Console.WriteLine("O número de IP correspondente à URL digitada é: " + URL[url]);
        }
        else
            Console.WriteLine("A URL digitada não está cadastrada!");
    }
}