using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Echecs.IHM;

namespace TP2_Echecs.Echecs
{
    class Pion : Piece
    {
        bool deplacementJoueur = false;
        int coordPion = 0; 
        public Pion(Joueur joueur) : base(TypePiece.Pion, joueur)
        {
        }

        public override bool Deplacer(Case destination)
        {
            destination.Link(this); 
            return true;
        }
    }
}
