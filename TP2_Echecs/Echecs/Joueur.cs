using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Echecs.IHM;

namespace TP2_Echecs.Echecs
{
    public class Joueur
    {
        // attributs
        public CouleurCamp couleur;

        // associations
        public Partie partie;
        public List<Piece> pieces = new List<Piece>();

        // methodes
        public Joueur(Partie partie, CouleurCamp couleur)
        {
            this.couleur = couleur;
            this.partie = partie;

            pieces.Add( new Dame(this));
            pieces.Add(new Roi(this)); 
            pieces.Add(new Tour(this));
            pieces.Add(new Tour(this));
            pieces.Add(new Pion(this));
            pieces.Add(new Pion(this));
            pieces.Add(new Pion(this));
            pieces.Add(new Pion(this));
            pieces.Add(new Pion(this));
            pieces.Add(new Pion(this));
            pieces.Add(new Pion(this));
            pieces.Add(new Pion(this));
            pieces.Add(new Fou(this));
            pieces.Add(new Fou(this));
            pieces.Add(new Cavalier(this));
            pieces.Add(new Cavalier(this));

        }

        public void PlacerPieces(Echiquier echiquier)
        {
            if (couleur == CouleurCamp.Noire)
            {
                echiquier.cases[3, 0].Link(pieces[0]);
                echiquier.cases[4, 0].Link(pieces[1]);
                echiquier.cases[0, 0].Link(pieces[2]);
                echiquier.cases[7, 0].Link(pieces[3]);
                echiquier.cases[0, 1].Link(pieces[4]);
                echiquier.cases[1, 1].Link(pieces[5]);
                echiquier.cases[2, 1].Link(pieces[6]);
                echiquier.cases[3, 1].Link(pieces[7]);
                echiquier.cases[4, 1].Link(pieces[8]);
                echiquier.cases[5, 1].Link(pieces[9]);
                echiquier.cases[6, 1].Link(pieces[10]);
                echiquier.cases[7, 1].Link(pieces[11]);
                echiquier.cases[2, 0].Link(pieces[12]);
                echiquier.cases[5, 0].Link(pieces[13]);
                echiquier.cases[1, 0].Link(pieces[14]);
                echiquier.cases[6, 0].Link(pieces[15]);

            }
            else
            {
                echiquier.cases[3, 7].Link(pieces[0]);
                echiquier.cases[4, 7].Link(pieces[1]);
                echiquier.cases[0, 7].Link(pieces[2]);
                echiquier.cases[7, 7].Link(pieces[3]);
                echiquier.cases[0, 6].Link(pieces[4]);
                echiquier.cases[1, 6].Link(pieces[5]);
                echiquier.cases[2, 6].Link(pieces[6]);
                echiquier.cases[3, 6].Link(pieces[7]);
                echiquier.cases[4, 6].Link(pieces[8]);
                echiquier.cases[5, 6].Link(pieces[9]);
                echiquier.cases[6, 6].Link(pieces[10]);
                echiquier.cases[7, 6].Link(pieces[11]);
                echiquier.cases[2, 7].Link(pieces[12]);
                echiquier.cases[5, 7].Link(pieces[13]);
                echiquier.cases[1, 7].Link(pieces[14]);
                echiquier.cases[6, 7].Link(pieces[15]);
            }
        }
    }
}
