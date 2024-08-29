using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    internal abstract class Item
    {
        public string Name { get; set; }

        protected Item(string name)
        {
            Name = name;
        }

        public abstract void Use();
    }
}
