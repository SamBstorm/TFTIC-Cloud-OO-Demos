using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_Event
{
    internal delegate void GooseGameAction(object sender, GooseGameEventArgs args);
    internal class GooseGame
    {

        private List<Joueur> _players;

        private List<CaseJeu> _plateau;

        public event GooseGameAction gooseGamePlayerMove;
        public event GooseGameAction gooseGamePlayerDice;
        public event GooseGameAction gooseGameGameOver;

        public GooseGame(List<Joueur> joueurs) {
            _players = joueurs;
            _plateau = new List<CaseJeu> ();
            for (int i = 0; i < 63; i++)
            {
                if(i == 7 || i == 12 || i == 19 || i == 24 || i == 31 || i == 36 || i == 43 || i == 48)
                {
                    _plateau.Add (new CaseSpecial ("Case oie",
                        delegate (Joueur currentPlayer, GooseGame game)
                        {
                            currentPlayer.Avancer(6);
                            gooseGamePlayerMove?.Invoke(currentPlayer, new GooseGameEventArgs
                            {
                                Message = $"Le joueur {currentPlayer.Name} a atérri sur la case \"Case oie\". Et avance de 6 case! Il est maintenant en case {currentPlayer.Position}!",
                                Couleur = currentPlayer.Couleur
                            });
                        }
                        ));
                }
                else if(i == 58)
                {
                    _plateau.Add(new CaseSpecial("Case cimetière",
                        delegate (Joueur currentPlayer, GooseGame game)
                        {
                            currentPlayer.Reculer(currentPlayer.Position);
                            gooseGamePlayerMove?.Invoke(currentPlayer, new GooseGameEventArgs
                            {
                                Message = $"Le joueur {currentPlayer.Name} a atérri sur la case \"Case cimetière\". Et retourne à la case départ!",
                                Couleur = currentPlayer.Couleur
                            });
                        }
                        ));
                }
                else
                {
                    _plateau.Add (new CaseJeu ());
                }
            }
        }

        public void StartGame()
        {
            bool gameOver = false;
            Random RNG = new Random ();
            int playerIndex = RNG.Next (0, _players.Count);
            do
            {
                playerIndex = (playerIndex+1) % _players.Count;
                Joueur p = _players[playerIndex];
                int[] dices = p.LancerDe();
                gooseGamePlayerDice?.Invoke(p,new GooseGameEventArgs()
                {
                    Message = $"Le joueur {p.Name} a obtenu : {dices[0]} & {dices[1]}."
                    ,Couleur = p.Couleur
                });
                if (p.Position > _plateau.Count)
                {
                    p.Reculer((p.Position % _plateau.Count)*2);
                }
                gooseGamePlayerMove?.Invoke(p,
                    new GooseGameEventArgs { Message = $"Le joueur {p.Name} est en case {p.Position}.", Couleur = p.Couleur });
                if (p.Position == _plateau.Count)
                {
                    {
                        gameOver = true;
                        gooseGameGameOver?.Invoke(p,
                            new GooseGameEventArgs { Message = $"Le joueur {p.Name} est vainqueur!", Couleur = p.Couleur });
                    }
                }
                else
                {
                    ActiverCase(p);
                }
            } while (!gameOver);
        }

        private void ActiverCase(Joueur currentPlayer)
        {
            CaseJeu currentCase = _plateau[currentPlayer.Position];
            if (currentCase is CaseSpecial cs) {
                cs.ActiverAction(currentPlayer, this);
            }
        }
    }
}
