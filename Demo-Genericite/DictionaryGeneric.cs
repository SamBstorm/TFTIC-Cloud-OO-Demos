using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Genericite
{
    internal class DictionaryGeneric<TKey,TValue>
    {

        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < _dictionary.Count; i++) {
                    KVP<TKey, TValue> kvp = _dictionary[i];
                    if (ReferenceEquals(kvp.Key, key)) return kvp.Value;
                }
                throw new ArgumentOutOfRangeException(nameof(key));
            }
            set
            {
                for (int i = 0; i < _dictionary.Count; i++)
                {
                    KVP<TKey, TValue> kvp = _dictionary[i];
                    if (ReferenceEquals(kvp.Key, key))
                    {
                        kvp.Value = value;
                        return;
                    }
                }
                throw new ArgumentOutOfRangeException(nameof(key));
            }
        }

        public List<TKey> Keys { get
            {
                List<TKey> keys = new List<TKey>();
                for (int i = 0; i < _dictionary.Count; i++)
                {
                    KVP<TKey, TValue> kvp = _dictionary[i];
                    keys.Add(kvp.Key);
                }
                return keys;
            } 
        }

        private ListGeneric<KVP<TKey,TValue>> _dictionary = new ListGeneric<KVP<TKey, TValue>>();

        public void Add(TKey key, TValue value) {
            for (int i = 0; i < _dictionary.Count; i++)
            {
                KVP<TKey,TValue> kvp = _dictionary[i];
                if(ReferenceEquals(kvp.Key, key)) throw new ArgumentException(nameof(key));
            }
            _dictionary.Add(new KVP<TKey, TValue> { Key = key, Value = value });
        }
    }
}
