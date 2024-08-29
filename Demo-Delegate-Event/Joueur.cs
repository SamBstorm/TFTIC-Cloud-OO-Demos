namespace Demo_Delegate_Event
{
    internal class Joueur
    {
        public string Name { get; }
        public JeuCouleur Couleur { get; }
        public int Position { get; private set; }

        public Joueur(string name, JeuCouleur couleur)
        {
            Name = name;
            Couleur = couleur;
            Position = 0;
        }

        public int[] LancerDe()
        {
            Random RNG = new Random();
            int[] result = new int[2];
            int total = 0;
            for (int i = 0; i < 2; i++)
            {
                result[i] = RNG.Next(1, 7);
                total+= result[i];
            }
            Position += total; 
            return result;
        }

        public void Reculer(int nombreCase)
        {
            Position -= nombreCase;
        }


        public void Avancer(int nombreCase)
        {
            Position += nombreCase;
        }
    }
}