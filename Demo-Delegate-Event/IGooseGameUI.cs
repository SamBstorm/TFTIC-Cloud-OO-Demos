using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_Event
{
    internal interface IGooseGameUI
    {
        public void AfficherMessage(object sender, GooseGameEventArgs args);
    }
}
