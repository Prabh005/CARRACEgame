using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame.AllClasses
{
   public abstract class Punter
    {
        public string PunterName { get; set; }

        public string Car { get; set; }

        public Single Money { get; set; }

        public Single Bet { get; set; }

        public Label LabelWinner { get; set; }
        public Color MyColor { get; set; }

       

    }
}
