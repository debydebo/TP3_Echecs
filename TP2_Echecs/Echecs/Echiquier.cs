using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Echecs.Echecs
{
    public class Echiquier
    {
        //attributs 
        int raw, col;
        Partie partie;
        public Case[,] cases; 
        public Echiquier(Partie partie)
        {
            this.partie = partie;
            raw = 8;
            col = 8;
            cases = new Case[raw, col];
            for (int i = 0; i < raw; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    cases[i, j] = new Case(partie, null, 0, i, j); 
                }
            }
        }

    }
}
