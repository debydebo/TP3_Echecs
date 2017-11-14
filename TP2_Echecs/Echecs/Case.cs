using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Echecs.IHM;

namespace TP2_Echecs.Echecs
{
    public class Case 
    {

        // attributs
        public CouleurCamp couleurCase; 
        public int x, y;
       
        Partie partie;
        public Piece piece;
        public  Case newCase;
        Case oldCase;
        // associations
        public Case(Partie partie, Piece piece, CouleurCamp couleurCase, int x, int y)
        {        
            this.partie = partie;
            this.piece = piece;
            this.couleurCase = couleurCase;
            this.x = x;
            this.y = y;
        }
        // methodes
        public void Link(Piece newPiece)
        {
            newCase = new Case(partie, piece, couleurCase, x, y);
            oldCase = new Case(partie, piece, couleurCase, x, y);
            oldCase = piece.position;
            if (newCase.piece == null)
            {
                oldCase.UnLink(piece);
                newCase.piece = newPiece;
                newPiece.position = newCase;

            }
            // case pair
            if ((x % 2) == 0)
            {
                couleurCase = CouleurCamp.Jaune;
            }
            else  couleurCase = CouleurCamp.Marron;

            partie.vue.ActualiserCase(x, y, newPiece.info);

        }
        public void UnLink(Piece newPiece)
        {
            newPiece = null;
            partie.vue.ActualiserCase(x, y, null);
        }
    }
}
