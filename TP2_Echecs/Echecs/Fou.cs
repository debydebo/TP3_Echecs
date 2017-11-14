using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Echecs.IHM;

namespace TP2_Echecs.Echecs
{
    class Fou : Piece
    {
        public Fou(Joueur joueur) : base(TypePiece.Fou, joueur)
        {
        }

        public override bool Deplacer(Case destination)
        {
            destination.Link(this);
            return true; 
        }
    }
}
