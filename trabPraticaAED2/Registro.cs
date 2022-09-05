using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class Registro
    {
        private int key;
        private String value;
        private Registro proximo;
        public Registro()
        {
            this.proximo = null;
        }
        public Registro(int key, String value)
        {
            this.key = key;
            this.value = value;
            this.proximo = null;
        }
        public void setKey(int key)
        {
            this.key = key;
        }
        public void setValue(String value)
        {
            this.value = value;
        }
        public void setProximo(Registro proximo)
        {
            this.proximo = proximo;
        }
        public int getKey()
        {
            return this.key;
        }
        public String getValue()
        {
            return this.value;
        }
        public Registro getProximo()
        {
            return this.proximo;
        }
        public int hashCode()
        {
            return key % 100;
        }
    }
}