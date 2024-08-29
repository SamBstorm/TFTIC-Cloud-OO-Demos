using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_Event
{
    internal class ConsoleUI : IGooseGameUI
    {
        public void AfficherMessage(object sender, GooseGameEventArgs args)
        {
            AfficherMessage(args.Message, ((Joueur)sender).Couleur);
        }
        public void AfficherMessage(string message, JeuCouleur color)
        {
            Console.Clear();
            Console.BackgroundColor = Enum.Parse<ConsoleColor>(color.ToString());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.ReadKey();
        }
    }
}
