using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Genericite
{
    internal class ListGeneric<T>
    {
        public T this[int index]
        {
            get { return (T)_list[index]; }
            set
            {
                if (index >= _list.Count) throw new ArgumentOutOfRangeException(nameof(index));
                _list[index] = value;
            }
        }
        public int Count { get { return _list.Count; } }

        private ArrayList _list = new ArrayList();

        public void Add(T value)
        {
            _list.Add(value);
        }
    }
}
