using System;
using System.Collections;
using System.Collections.Generic;

class Morador
{
    public string CPF;
    public string Nome;
    public string QtdDependentes;
    public long RendaF;
    public string Telefone;
    public string Endereco;
}

class Program
{
    public static long tam1, tam2, tamE, salM;
    public static List<Morador> lista1 = new List<Morador>();
    public static List<Morador> lista2 = new List<Morador>();
    public static List<Morador> listaEspera = new List<Morador>();
    public static Morador moradorRemover = null;
    public static void CadastrarMorador(List<Morador> lista1, List<Morador> lista2, List<Morador> listaEspera)
    {
        Console.WriteLine("OPÇÃO SELECIONADA: Cadastro.\n");
        Console.WriteLine("Capacidade da Lista 1: " + lista1.Capacity);
        Console.WriteLine("Capacidade da Lista 2: " + lista2.Capacity);
        Console.WriteLine("Capacidade da Lista Espera: " + listaEspera.Capacity);
        Console.WriteLine(" ");

        int num;
        Console.Write("Quantos moradores deseja cadastrar? ");
        num = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            Morador Mor = new Morador();
            Console.Write("\nDigite o número do seu CPF: ");
            Mor.CPF = Console.ReadLine();
            Console.Write("Digite seu Nome: ");
            Mor.Nome = Console.ReadLine();
            Console.Write("Digite a quantidade de dependentes: ");
            Mor.QtdDependentes = Console.ReadLine();
            Console.Write("Informe a sua renda familiar: ");
            Mor.RendaF = long.Parse(Console.ReadLine());
            Console.Write("Digite o número do seu telefone: ");
            Mor.Telefone = Console.ReadLine();
            Console.Write("Informe o seu endereço: ");
            Mor.Endereco = Console.ReadLine();
            Console.WriteLine("Morador foi cadastrado com sucesso");

            if (Mor.RendaF <= salM)
            {
                if (lista1.Count <= lista1.Capacity)
                    lista1.Add(Mor);
                else
                {
                    if (listaEspera.Count < listaEspera.Capacity)
                        listaEspera.Add(Mor);
                    else
                        Console.WriteLine("Lista de espera cheia.");
                }


            }
            if (Mor.RendaF > salM && Mor.RendaF <= salM * 3)
            {
                if (lista2.Count <= lista1.Capacity)
                    lista2.Add(Mor);
                else
                {
                    if (listaEspera.Count < listaEspera.Capacity)
                        listaEspera.Add(Mor);
                    else
                        Console.WriteLine("Lista de espera cheia.");
                }

            }
        }
    }
    public static void ImprimirListaMorador(List<Morador> lista1, List<Morador> lista2)
    {
        int op;
        Console.WriteLine("OPÇÃO SELECIONADA: Imprimir lista de Moradores.\n");
        Console.WriteLine("Para Listagem Simples: (1) Para Listagem Completa: (2)");
        op = int.Parse(Console.ReadLine());
        if (op == 1)
        {
            Console.WriteLine("Pressione uma tecla para imprimir a Lista 1... ");
            Console.ReadKey();
            Console.WriteLine("Imprimindo lista 1: ");
            foreach (Object item in lista1)
            {
                Console.Write("CPF - " + ((Morador)item).CPF);
                Console.Write(" - Nome - " + ((Morador)item).Nome);
                Console.Write(" - Renda Familiar - R$" + ((Morador)item).RendaF);
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Pressione uma tecla para imprimir a Lista 2... ");
            Console.ReadKey();
            Console.WriteLine("Imprimindo lista 2: ");
            foreach (Object item in lista2)
            {
                Console.Write("CPF - " + ((Morador)item).CPF);
                Console.Write(" - Nome - " + ((Morador)item).Nome);
                Console.Write(" - Renda Familiar - R$" + ((Morador)item).RendaF);
                Console.WriteLine("\n");
            }
        }
        if (op == 2)
        {
            Console.WriteLine("Pressione uma tecla para imprimir a Lista 1... ");
            Console.ReadKey();
            Console.WriteLine("Imprimindo lista 1: ");
            foreach (Object item in lista1)
            {
                Console.Write("CPF - " + ((Morador)item).CPF);
                Console.Write(" - Nome - " + ((Morador)item).Nome);
                Console.Write("\nQtd. de Dependentes - " + ((Morador)item).QtdDependentes);
                Console.Write(" - Renda Familiar R$" + ((Morador)item).RendaF);
                Console.Write("\nTelefone - " + ((Morador)item).Telefone);
                Console.Write("\nEndereço - " + ((Morador)item).Endereco);
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Pressione uma tecla para imprimir a Lista 2... ");
            Console.ReadKey();
            Console.WriteLine("Imprimindo lista 2: ");
            foreach (Object item in lista2)
            {
                Console.Write("CPF - " + ((Morador)item).CPF);
                Console.Write(" - Nome - " + ((Morador)item).Nome);
                Console.Write("\nQtd. de Dependentes - " + ((Morador)item).QtdDependentes);
                Console.Write(" - Renda Familiar R$" + ((Morador)item).RendaF);
                Console.Write("\nTelefone - " + ((Morador)item).Telefone);
                Console.Write("\nEndereço - " + ((Morador)item).Endereco);
                Console.WriteLine("\n");
            }
        }
        Console.WriteLine("\n");
        Console.WriteLine("Pressione uma tecla para sair... ");
        Console.ReadKey();
    }
    public static void ImprimirListaEspera(List<Morador> listaEspera)
    {
        Console.WriteLine("OPÇÃO SELECIONADA: Imprimir Lista de Espera \n");
        Console.WriteLine("Pressione uma tecla para imprimir a lista de Espera...");
        Console.ReadKey();
        Console.WriteLine("Imprimindo Lista de Espera...\n");
        foreach (Object item in listaEspera)
        {
            Console.WriteLine("CPF: " + ((Morador)item).CPF);
            Console.WriteLine("Nome: " + ((Morador)item).Nome);
            Console.WriteLine("==============");
        }
        Console.WriteLine("Pressione qualquer tecla para voltar para o menu.");
        Console.ReadKey();
    }
    public static void PesquisarMorador(List<Morador> lista1, List<Morador> lista2, List<Morador> listaEspera)

    {
        long cpf;
        Console.WriteLine("OPÇÃO SELECIONADA: Pesquisar Morador \n");
        Console.WriteLine("Digite o CPF do Morador que deseja pesquisar: ");
        cpf = long.Parse(Console.ReadLine());
        Console.WriteLine("Pesquisando morador na Lista 1...");
        bool existeMoradorLista1 = false;
        bool existeMoradorLista2 = false;
        bool existeMoradorListaE = false;

        foreach (var item in lista1)
        {
            if (cpf.ToString().Equals(item.CPF))
            {
                Console.WriteLine("O morador pesquisado é: \nCPF: " + item.CPF);
                Console.WriteLine("Nome: " + item.Nome);
                existeMoradorLista1 = true;
            }
        }
        if (!existeMoradorLista1)
        {
            Console.WriteLine("O morador não se encontra na Lista 1.");
        }

        Console.WriteLine("Pesquisando morador na Lista 2...");
        foreach (var item in lista2)
        {
            if (cpf.ToString().Equals(item.CPF))
            {
                Console.WriteLine("O morador pesquisado é: \nCPF: " + item.CPF);
                Console.WriteLine("Nome: " + item.Nome);
                existeMoradorLista2 = true;
            }
        }
        if (!existeMoradorLista2)
        {
            Console.WriteLine("O morador não se encontra na Lista 2.");
        }
        foreach (var itemE in listaEspera)
        {
            if (cpf.ToString().Equals(itemE.CPF))
            {
                Console.WriteLine("O morador pesquisado é: \nCPF: " + itemE.CPF);
                Console.WriteLine("Nome: " + itemE.Nome);
                existeMoradorListaE = true;
            }
            if (!existeMoradorListaE)
            {
                Console.WriteLine("O morador não se encontra na Lista de Espera.");
            }
        }
        Console.WriteLine(" ");
        Console.ReadKey();
    }
    public static void DesistenciaExcluir(List<Morador> lista1, List<Morador> lista2, List<Morador> listaEspera)
    {
        Console.WriteLine("OPÇÃO SELECIONADA: Excluir morador. \n");
        Console.WriteLine("Informe o CPF do Morador que deseja excluir: \n");
        string cpfInformado = Console.ReadLine();

        foreach (var item in lista1)
        {
            if (item.CPF == cpfInformado)
            {
                moradorRemover = item;
                break;
            }
            Console.WriteLine("CPF: " + moradorRemover.CPF);
            Console.WriteLine("Nome: " + moradorRemover.Nome);
            Console.WriteLine("Deseja excluir o morador mencionado? ");
            Console.WriteLine("(1) para sim (2) para não");
            int op1 = int.Parse(Console.ReadLine());

            if (op1 == 1)
            {
                Console.WriteLine("Morador excluído com sucesso.");
                Console.WriteLine("Pressiona qualquer tecla para continuar...");
                Console.ReadKey();
                lista1.Remove(moradorRemover);
                lista1.TrimExcess();
            }
            else if (op1 == 2)
            {
                Console.WriteLine("Morador não será excluido");
                Console.WriteLine("Pressiona qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        foreach (var item in lista2)
        {
            if (item.CPF == cpfInformado)
            {
                moradorRemover = item;
                break;
            }
            Console.WriteLine("CPF: " + moradorRemover.CPF);
            Console.WriteLine("Nome: " + moradorRemover.Nome);
            Console.WriteLine("Deseja excluir o morador mencionado? ");
            Console.WriteLine("(1) para sim (2) para não");
            int op2 = int.Parse(Console.ReadLine());
            if (op2 == 1)
            {
                Console.WriteLine("Morador excluído com sucesso.");
                Console.WriteLine("Pressiona qualquer tecla para continuar...");
                Console.ReadKey();
                lista2.Remove(moradorRemover);
                lista2.TrimExcess();
            }
            else if (op2 == 2)
            {
                Console.WriteLine("Morador não será excluido");
                Console.ReadKey();
            }
        }
        foreach (var item in listaEspera)
            if (item.CPF == cpfInformado)
            {
                moradorRemover = item;
                break;
            }
        Console.WriteLine("CPF: " + moradorRemover.CPF);
        Console.WriteLine("Nome: " + moradorRemover.Nome);
        Console.WriteLine("Deseja excluir o morador mencionado? ");
        Console.WriteLine("(1) para sim (2) para não");
        int op3 = int.Parse(Console.ReadLine());
        if (op3 == 1)
        {
            Console.WriteLine("Morador excluído com sucesso.");
            Console.WriteLine("Pressiona qualquer tecla para continuar...");
            Console.ReadKey();
            lista1.Remove(moradorRemover);
            listaEspera.TrimExcess();
        }
        else if (op3 == 2)
        {
            Console.WriteLine("Morador não será excluido");
            Console.ReadKey();
        }
    }
    public static void Sorteio(List<Morador> lista1, List<Morador> lista2)
    {
        Random rnd = new Random();
        var numeroAleatorio = rnd.Next(lista1.Count - 1);
        long moradiasSorteadasL1;
        long moradiasSorteadasL2;
        int resp = 0;
        int i = 0;
        int c = 0;
        Console.WriteLine("OPÇÃO SELECIONADA: Sorteio \n");
        Console.WriteLine("Informe a quantidade de moradias a serem sorteadas na Lista 1: \n");
        moradiasSorteadasL1 = long.Parse(Console.ReadLine());
        /*Console.WriteLine("Informe a quantidade de moradias a serem sorteadas na Lista 2: \n");
        moradiasSorteadasL2 = long.Parse(Console.ReadLine()); */

        while (i < moradiasSorteadasL1)
        {
            foreach (var item in lista1)
                resp = rnd.Next(lista1.Count);
            Console.WriteLine("O morador " + ((Morador)lista1[resp]).Nome + " foi o ganhador do sorteio da lista 1");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            i++;
        }

        /*
        while (c<moradiasSorteadasL2)
        {

            foreach (var item in lista2)
                resp = rnd.Next(lista2.Count);
            Console.WriteLine("O morador " + ((Morador)lista2[resp]).Nome + " foi o ganhador do sorteio da lista 2");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            c++;
        }
        */

    }
    public static void Parametros(out List<Morador> lista1, out List<Morador> lista2)
    {
        Console.WriteLine("OPÇÃO SELECIONADA: Parametros. \n");
        Console.WriteLine("Defina o tamanho da Lista 1: ");
        tam1 = long.Parse(Console.ReadLine());
        lista1 = new List<Morador>((int)tam1);
        Console.WriteLine("Defina o tamanho da Lista 2: ");
        tam2 = long.Parse(Console.ReadLine());
        lista2 = new List<Morador>((int)tam2);
        Console.WriteLine("Defina o tamanho da Lista de Espera: ");
        tamE = long.Parse(Console.ReadLine());
        listaEspera = new List<Morador>((int)tamE);
        Console.WriteLine("Defina o salário mínimo: ");
        salM = long.Parse(Console.ReadLine());
    }
    public static void Menu()
    {
        int op;
        do
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar morador");
            Console.WriteLine("2 - Imprimir lista de Moradores");
            Console.WriteLine("3 - Imprimir fila de espera");
            Console.WriteLine("4 - Pesquisar morador");
            Console.WriteLine("5 - Desistência/Excluir");
            Console.WriteLine("6 - Sorteio");
            Console.WriteLine("7 - Parametros");
            Console.WriteLine("8 - Sair");
            Console.WriteLine("\nDigite sua opção: ");
            op = Int32.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    CadastrarMorador(lista1, lista2, listaEspera);
                    break;
                case 2:
                    Console.Clear();
                    ImprimirListaMorador(lista1, lista2);
                    break;
                case 3:
                    Console.Clear();
                    ImprimirListaEspera(listaEspera);
                    break;
                case 4:
                    Console.Clear();
                    PesquisarMorador(lista1, lista2, listaEspera);
                    break;
                case 5:
                    Console.Clear();
                    DesistenciaExcluir(lista1, lista2, listaEspera);
                    break;
                case 6:
                    Console.Clear();
                    Sorteio(lista1, lista2);
                    break;
                case 7:
                    Console.Clear();
                    Parametros(out lista1, out lista2);
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (op != 8);
    }
    public static void Main(string[] args)
    {
        Menu();
    }
}