using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p19_t3
{
    class Element
    {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public Element(string Key, string Value)
        {
            if (string.IsNullOrEmpty(Key))
            {
                throw new ArgumentNullException(nameof(Key));
            }

            if (string.IsNullOrEmpty(Value))
            {
                throw new ArgumentNullException(nameof(Value));
            }

            this.Key = Key;
            this.Value = Value;
        }
        
        

        public override string ToString()
        {
            return Key;
        }
    }

    class HashTable
    {
        int size;
        public HashTable(int size)
        {
            this.size = size;
        }
        int Hash(int key)
        {
            return key % size;
        }
    }
}
