using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Echecs.IHM;

namespace TP2_Echecs.Echecs
{
    class Roi : Piece
    {
        public Roi(Joueur joueur) : base(TypePiece.Roi, joueur)
        {
        }

        public override bool Deplacer(Case destination)
        {
            destination.Link(this); 
            return true; 
        }
    }
}
