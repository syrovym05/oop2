using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol2oop
{
    internal class Tahac : NakladniAuto
    {
        private int nosnostVlecky;

        public Tahac(int nosnostVlecky, string spz, int nosnost) : base(spz, nosnost)
        {
            this.nosnostVlecky = nosnostVlecky;
            base.nosnost += nosnostVlecky;
        }


  

    }
}
