using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hash
{
    class Program
    {
        public static void Main(String[] args)
        {
            int op;
            Console.WriteLine("Digite a opção desejada: (1) - Inserir No Hash   (2) - Aplicação  (3) - MostrarHash");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    InserindoNoHash();
                    break;
                case 2:
                    Aplicacao();
                    break;
                case 3:
                    MostrarHash();
                    break;
            }
        }
        public static void InserindoNoHash()
        {
            String texto;
            int chave;
            int continua;
            MapaHash mapa = new MapaHash();
            Registro r;
            do
            {
                Console.WriteLine("Digite uma chave");
                texto = Console.ReadLine();
                chave = Int32.Parse(texto);
                Console.WriteLine("Digite um valor");
                texto = Console.ReadLine();
                r = new Registro(chave, texto);
                mapa.put(r);
                Console.WriteLine("Continua? (1) - Sim / (0) - Não)");
                continua = int.Parse(Console.ReadLine());
            } while (continua != 0);
            Console.WriteLine("========================================");
            do
            {
                Console.WriteLine("Digite uma chave");
                chave = int.Parse(Console.ReadLine());
                if (chave != -1)
                {
                    r = mapa.get(chave);
                    if (r != null)
                    {
                        Console.WriteLine("Registro = " + r.getValue());
                    }
                    else
                    {
                        Console.WriteLine("Nao existe");
                    }
                }
            } while (chave != -1);
        }
        public static void Aplicacao()
        {
            int key;
            MapaHash mapa = new MapaHash();
            mapa.put(new Registro(7865, "Isidro"));
            mapa.put(new Registro(123, "Josineidson"));
            mapa.put(new Registro(987, "Nilsonclecio"));
            mapa.put(new Registro(9832, "Deosdedite"));
            do
            {
                Console.WriteLine("Digite um codigo de registro");
                key = int.Parse(Console.ReadLine());
                if (key != -1)
                {
                    Registro r = mapa.get(key);
                    if (r != null)
                    {
                        Console.WriteLine("Registro Recuperado = " + r.getKey() + " - " + r.getValue());
                    }
                    else
                    {
                        Console.WriteLine("Registro nao existente");
                    }
                }
            } while (key != -1);
        }
        public static void MostrarHash()
        {
            String s1, s2, s3, s4;
            s1 = "a";
            s2 = "b";
            s3 = "c";
            s4 = "d";
            Console.WriteLine("HashCode : " + s1.GetHashCode());
            Console.WriteLine("HashCode : " + s2.GetHashCode());
            Console.WriteLine("HashCode : " + s3.GetHashCode());
            Console.WriteLine("HashCode : " + s4.GetHashCode());
            Console.ReadKey();
        }
    }
}
