using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_Event
{
    internal class GooseGameEventArgs : EventArgs
    {
        public string Message { get; set; }
        public JeuCouleur Couleur { get; set; }
    }
}
