using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    internal enum EquipementLocalisation { Head, Torso, Legs, Arms }
    internal class EquipmentItem : Item, IDroppable
    {
        public EquipementLocalisation Localisation { get; set; }
        public EquipmentItem(string name, EquipementLocalisation localisation) : base(name)
        {
            Localisation = localisation;
        }

        public override void Use()
        {
            Console.WriteLine($"Vous enfillez {Name} sur {Localisation.ToString()}!");
        }

    }
}
