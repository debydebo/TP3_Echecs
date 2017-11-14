using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Echecs.IHM;

namespace TP2_Echecs.Echecs
{
    abstract public class Piece
    {
        // attributs
        public InfoPiece info;

        // associations
        public Joueur joueur;
        public Case position;
        Partie partie;
        int x, y;
        public Piece piece { get; private set; }
        CouleurCamp couleur;
       
        // methodes
        public Piece(TypePiece type, Joueur joueur)
        {
            
			this.joueur = joueur;
            info = InfoPiece.GetInfo(joueur.couleur, type);
            position = new Case(partie, piece, couleur, x, y);
                
            
            
            
        }

        public abstract bool Deplacer(Case destination);
    }
}
