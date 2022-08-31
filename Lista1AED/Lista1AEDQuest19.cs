using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
       {
        Console.WriteLine("19 – Crie um dicionário com URLs e IPs dos websites abaixo e mais 5 à sua escolha. O seu dicionário deve ser implementado usando a classe Hashtable e terá a URL como chave e o IP correspondente como valor (por exemplo, se digitarmos como chave a URL www.google.com, seu programa deve retornar o IP 74.125.234.81). O seu programa deve permitir que o usuário digite uma URL e deve imprimir o IP correspondente. Para descobrir o IP de um website, basta digitar ping + URL do website (exemplo: ping www.google.com). ");
        Console.WriteLine(" ");

        Hashtable URL = new Hashtable();
        String url;

        URL.Add("www.google.com", "172.217.173.100");
        URL.Add("www.pucminas.br", "200.229.32.28]");
        URL.Add("www.gmail.com", "172.217.30.165");
        URL.Add("www.youtube.com", "142.250.219.14");
        URL.Add("www.capes.gov.br", "200.130.18.127");
        URL.Add("www.wikipedia.com", "208.80.154.232");
        URL.Add("www.twitter.com", "104.244.42.1");
        URL.Add("www.microsoft.com", "92.122.29.159");
        URL.Add("www.amazon.com", "13.33.132.69");
        URL.Add("www.hotmail.com", "204.79.197.212");

        Console.Write("Digite o site que deseja pesquisar: ");
        url = Console.ReadLine();

        if (URL.ContainsKey(url))
            Console.WriteLine("O número de IP correspondente ao site digitado é: " + URL[url]);
        else
            Console.WriteLine("A URL digitada não está cadastrada!");
        }
    }
}