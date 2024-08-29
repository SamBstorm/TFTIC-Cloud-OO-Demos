namespace Demo_Delegate_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Joueur> joueurs = new List<Joueur>();
            bool enoughPlayers;
            do
            {
                enoughPlayers = false;
                if (joueurs.Count < 2)
                {
                    Console.WriteLine("Veuillez indiquer un nom :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Choissisez une couleur : Red - Blue - Yellow - Green");
                    string color = Console.ReadLine();
                    joueurs.Add(new Joueur(name, Enum.Parse<JeuCouleur>(color)));
                }
                else
                {
                    Console.WriteLine("Voulez-vous ajouter un autre joueur ? Oui - Non");
                    if(Console.ReadLine().ToUpper() == "OUI")
                    {
                        Console.WriteLine("Veuillez indiquer un nom :");
                        string name = Console.ReadLine();
                        Console.WriteLine("Choissisez une couleur : Red - Blue - Yellow - Green");
                        string color = Console.ReadLine();
                        joueurs.Add(new Joueur(name, Enum.Parse<JeuCouleur>(color)));
                    }
                    else
                    {
                        enoughPlayers = true;
                    }
                }
            } while (joueurs.Count < 4 && !enoughPlayers);
            GooseGame jeu = new GooseGame(joueurs);
            IGooseGameUI ui = new ConsoleUI();
            //jeu.gooseGamePlayerDice += SoundFX.MakeNoise;
            jeu.gooseGamePlayerDice += ui.AfficherMessage;
            //jeu.gooseGameGameOver += SoundFX.VictoryMusic;
            jeu.gooseGameGameOver += ui.AfficherMessage;
            //jeu.gooseGamePlayerMove += SoundFX.MakeNoise;
            jeu.gooseGamePlayerMove += ui.AfficherMessage;
            jeu.StartGame();
        }
    }
}
