using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_Event
{
    internal delegate void CaseSpecialAction(Joueur currentPlayer, GooseGame game);
    internal class CaseSpecial : CaseJeu
    {
        private CaseSpecialAction _action;
        public string Name { get; }

        public CaseSpecial(string name, CaseSpecialAction action)
        {
            Name = name;
            _action = action;
        }

        public void ActiverAction(Joueur currentPlayer, GooseGame game)
        {
            _action(currentPlayer, game);
        }
    }
}
