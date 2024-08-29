using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    internal class QuestItem : Item, IOneUse
    {
        public string Description { get; set; }
        public QuestItem(string name, string description) : base(name)
        {
            Description = description;
        }

        public override void Use()
        {
            Console.WriteLine($"Vous utilisez {Name}...");
            Console.WriteLine($"Selon les dire cela fait : {Description}...");
        }
    }
}
