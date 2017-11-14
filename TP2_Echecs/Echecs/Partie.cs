﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Echecs.IHM;

namespace TP2_Echecs.Echecs
{
    public class Partie : IJeu
    {
        public IEvenements vue
        {
            get { return _vue; }
            set {_vue = value; }
        }

        StatusPartie status
        {
            get { return _status; }
            set
            {
                _status = value;
                vue.ActualiserPartie(_status);
            }
        }


        /* attributs */

        public StatusPartie _status = StatusPartie.Reset;


        /* associations */
        
        IEvenements _vue;
        Joueur blancs;
        Joueur noirs;
        Echiquier echiquier;  // TODO : décommentez lorsque vous auriez implementé la classe Echiquier


        /* methodes */

        public void CommencerPartie()
        {
            // creation des joueurs
            blancs = new Joueur(this, CouleurCamp.Blanche);
            noirs = new Joueur(this, CouleurCamp.Noire);

            // creation de l'echiquier
            echiquier = new Echiquier(this);

            // placement des pieces
            blancs.PlacerPieces(echiquier);  
            noirs.PlacerPieces(echiquier);  

            /* TEST */
            //vue.ActualiserCase(3, 0, InfoPiece.DameNoire);
            //vue.ActualiserCase(3, 7, InfoPiece.DameBlanche);
            /* FIN TEST */

            // initialisation de l'état
            status = StatusPartie.TraitBlancs;         
        }

        public void DeplacerPiece(int x_depart, int y_depart, int x_arrivee, int y_arrivee)
        {
            /* TEST */
            //vue.ActualiserCase(x_depart,  y_depart,  null);
            //vue.ActualiserCase(x_arrivee, y_arrivee, InfoPiece.FouBlanc);
            /* FIN TEST */

            // case de départ
            Case depart = echiquier.cases[x_depart, y_depart];

            // case d'arrivée
            Case destination = echiquier.cases[x_arrivee, y_arrivee];

            // deplacer
            bool ok = depart.piece.Deplacer(destination);


            //changer d'état
            if (ok)
                ChangerEtat();
           // vue.ActualiserCase(x_depart,  y_depart,  null);
        }

        void ChangerEtat(bool echec = false, bool mat = false)
        {
            if (status == StatusPartie.TraitBlancs)
            {
                status = StatusPartie.TraitNoirs;
            }
            else
            {
                status = StatusPartie.TraitBlancs;
            }

        }
    }
}
