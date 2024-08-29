using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    internal class HealItem : Item, IDroppable, IOneUse
    {
        public int HealPoint { get; set; }
        public HealItem(string name, int healPoint) : base(name)
        {
            HealPoint = healPoint;
        }
        public override void Use()
        {
            Console.WriteLine($"Vous vous soignez de {HealPoint} PV!"); ;
        }
    }
}
