using System;
using System.Collections;

namespace segundaLista
{
    class CCelula
    {
        public Object Item;
        public CCelula Prox;
        public CCelula()
        {
            Item = null;
            Prox = null;
        }
        public CCelula(object ValorItem)
        {
            Item = ValorItem;
            Prox = null;
        }
        public CCelula(object ValorItem, CCelula ProxCelula)
        {
            Item = ValorItem;
            Prox = ProxCelula;
        }
    }

    class CFila
    {
        private CCelula Frente;
        private CCelula Tras;
        private int Qtde = 0;

        public CFila()
        {
            Frente = new CCelula();
            Tras = Frente;
        }
        public bool Vazia()
        {
            return Frente == Tras;
        }
        public void Enfileira(Object ValorItem)
        {
            Tras.Prox = new CCelula(ValorItem);
            Tras = Tras.Prox;
            Qtde++;
        }
        public void Diferente(Object x)
        {
            CCelula aux = Frente;
            CCelula aux2 = aux.Prox;
            aux.Prox = new CCelula(x);
            aux.Prox.Prox = new CCelula(x);
            aux.Prox.Prox.Prox = aux2;
            if (aux2 == null)
                Tras = aux.Prox.Prox;
        }

        public void ImprimeFormatoLista()
        {
            Console.Write("[/]->");
            for (CCelula aux = Frente.Prox; aux != null; aux = aux.Prox)
                Console.Write("[" + aux.Item.ToString() + "]->");
            Console.WriteLine("null");
        }

        public Object Desenfileira()
        {
            Object Item = null;
            if (Frente != Tras)
            {
                Frente = Frente.Prox;
                Item = Frente.Item;
                Qtde--;
            }
            return Item;
        }

        public Object Peek()
        {
            if (Frente != Tras)
                return Frente.Prox.Item;
            else
                return null;
        }

        public bool Contem(Object elemento)
        {
            bool achou = false;
            CCelula aux = Frente.Prox;
            while (aux != null && !achou)
            {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }
        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (CCelula aux = Frente.Prox; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        public int Quantidade()
        {
            return Qtde;
        }

        public IEnumerator GetEnumerator()
        {
            for (CCelula aux = Frente.Prox; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }
        public CFila ConcatenaFila(CFila F1, CFila F2)
        {
            CFila F3 = new CFila();
            for (CCelula aux = Frente.Prox; aux != null; aux = aux.Prox)
                F3.Enfileira(aux.Item);
            for (CCelula aux = F2.Frente.Prox; aux != null; aux = aux.Prox)
                F3.Enfileira(aux.Item);
            return F3;
        }
    }
    class CLista
    {
        private CCelula Primeira;
        private CCelula Ultima;
        private int Qtde = 0;

        public CLista()
        {
            Primeira = new CCelula();
            Ultima = Primeira;
        }

        public bool Vazia()
        {
            return Primeira == Ultima;
        }

        public void InsereFim(Object ValorItem)
        {
            Ultima.Prox = new CCelula(ValorItem);
            Ultima = Ultima.Prox;
            Qtde++;
        }
        public void InsereComeco(Object ValorItem)
        {
            Primeira.Prox = new CCelula(ValorItem, Primeira.Prox);
            if (Primeira.Prox.Prox == null)
                Ultima = Primeira.Prox;
            Qtde++;
        }

        public void InsereAntesDe(Object ElementoAInserir, Object Elemento)
        {

            CCelula aux = Primeira.Prox;
            while (aux != null && !aux.Item.Equals(Elemento))
                aux = aux.Prox;
            if (aux != null)
            {
                aux.Prox = new CCelula(ElementoAInserir, aux.Prox);
                Qtde++;
            }

        }
        public void InsereDepoisDe(Object ElementoAInserir2, Object Elemento2)
        {
            CCelula aux = Primeira.Prox;
            while (aux != null && !aux.Item.Equals(Elemento2))
                aux = aux.Prox;
            if (aux != null)
            {
                aux.Prox = new CCelula(ElementoAInserir2, aux.Prox);
            }
        }
        public void Imprime()
        {
            CCelula aux = Primeira.Prox;
            while (aux != null)
            {
                Console.WriteLine(aux.Item);
                aux = aux.Prox;
            }
        }
        public void ImprimeFor()
        {
            for (CCelula aux = Primeira.Prox; aux != null; aux = aux.Prox)
                Console.Write(aux.Item);
        }

        public void ImprimeFormatoLista()
        {
            Console.Write("[/]->");
            for (CCelula aux = Primeira.Prox; aux != null; aux = aux.Prox)
                Console.Write("[" + aux.Item.ToString() + "]->");
            Console.WriteLine("null");
        }

        public bool Contem(Object elemento)
        {
            bool achou = false;
            CCelula aux = Primeira.Prox;
            while (aux != null && !achou)
            {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }

        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (CCelula aux = Primeira.Prox; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        public Object RemoveRetornaComeco()
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira.Prox;
                Primeira.Prox = aux.Prox;
                if (Primeira.Prox == null)
                    Ultima = Primeira;
                Qtde--;
                return aux.Item;
            }
            return null;
        }
        public Object RemoveRetornaComecoSimples()
        {
            if (Primeira != Ultima)
            {
                Primeira = Primeira.Prox;
                Qtde--;
                return Primeira.Item;
            }
            return null;
        }
        public void RemoveComecoSemRetorno()
        {
            if (Primeira != Ultima)
            {
                Primeira = Primeira.Prox;
                Qtde--;
            }
        }

        public Object RemoveRetornaFim()
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                while (aux.Prox != Ultima)
                    aux = aux.Prox;

                CCelula aux2 = aux.Prox;
                Ultima = aux;
                Ultima.Prox = null;
                Qtde--;
                return aux2.Item;
            }
            return null;
        }

        public void RemoveFimSemRetorno()
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                while (aux.Prox != Ultima)
                    aux = aux.Prox;

                Ultima = aux;
                Ultima.Prox = null;
                Qtde--;
            }
        }
        public void Remove(Object ValorItem)
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                bool achou = false;
                while (aux.Prox != null && !achou)
                {
                    achou = aux.Prox.Item.Equals(ValorItem);
                    if (!achou)
                        aux = aux.Prox;
                }
                if (achou)
                {
                    aux.Prox = aux.Prox.Prox;
                    if (aux.Prox == null)
                        Ultima = aux;
                    Qtde--;
                }
            }
        }
        public Object RetornaPrimeiro()
        {
            if (Primeira != Ultima)
                return Primeira.Prox.Item;
            else
                return null;
        }

        public Object RetornaUltimo()
        {
            if (Primeira != Ultima)
                return Ultima.Item;
            else
                return null;
        }
        public Object RetornaIndice(int Posicao)
        {
            if ((Posicao >= 1) && (Posicao <= Qtde) && (Primeira != Ultima))
            {
                int i = 1;
                CCelula aux = Primeira.Prox;
                while (i < Posicao)
                {
                    aux = aux.Prox;
                    i++;
                }
                return aux.Item;
            }
            return null;
        }
        public int Quantidade()
        {
            return Qtde;
        }
        public IEnumerator GetEnumerator()
        {
            for (CCelula aux = Primeira.Prox; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }

        public CLista ConcatenaListas(CLista L1, CLista L2)
        {
            CLista L3 = new CLista();
            for (CCelula aux = Primeira.Prox; aux != null; aux = aux.Prox)
                L3.InsereComeco(aux.Item);
            for (CCelula aux = L2.Primeira.Prox; aux != null; aux = aux.Prox)
                L3.InsereComeco(aux.Item);
            return L3;
        }
    }
        class CPilha
        {
            private CCelula Topo = null;
            private int Qtde = 0;
            public CPilha()
            {

            }
            public bool Vazia()
            {
                return Topo == null;
            }

            public void Empilha(Object ValorItem)
            {
                Topo = new CCelula(ValorItem, Topo);
                Qtde++;
            }
            public Object Desempilha()
            {
                Object Item = null;
                if (Topo != null)
                {
                    Item = Topo.Item;
                    Topo = Topo.Prox;
                    Qtde--;
                }
                return Item;
            }
            public bool Contem(Object elemento)
            {
                bool achou = false;
                CCelula aux = Topo;
                while (aux != null && !achou)
                {
                    achou = aux.Item.Equals(elemento);
                    aux = aux.Prox;
                }
                return achou;
            }

            public bool ContemFor(Object elemento)
            {
                bool achou = false;
                for (CCelula aux = Topo; aux != null && !achou; aux = aux.Prox)
                    achou = aux.Item.Equals(elemento);
                return achou;
            }
            public Object Peek()
            {
                if (Topo != null)
                    return Topo.Item;
                else
                    return null;
            }

            public int Quantidade()
            {
                return Qtde;
            }

            public IEnumerator GetEnumerator()
            {
                for (CCelula aux = Topo; aux != null; aux = aux.Prox)
                    yield return aux.Item;
            }
            public CPilha ConcatenaPilha(CPilha P1, CPilha P2)
        {
            CPilha P3 = new CPilha();
            for (CCelula aux = Topo; aux != null; aux = aux.Prox)
                P3.Empilha(aux.Item);
            for (CCelula aux = P2.Topo; aux != null; aux = aux.Prox)
                P3.Empilha(aux.Item);
            return P3;
        }
    }
}
