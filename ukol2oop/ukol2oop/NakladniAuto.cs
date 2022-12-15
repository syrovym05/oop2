using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ukol2oop
{
    class NakladniAuto
    {
        protected string spz;
        protected int nosnost { get; set; }
        protected int hmotnostnakladu =0;

        public int HmotnostNakladu  { get => hmotnostnakladu; }

        public NakladniAuto(string spz, int nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost; 
           
        }    

        public void NalozNaklad(int naklad)
        {
            if(hmotnostnakladu + naklad > nosnost)
            {
                MessageBox.Show(String.Format("Naklad byl naložen jen částečně, nebylo naloženo {0} tun písku", naklad + hmotnostnakladu - nosnost));
                hmotnostnakladu = nosnost;
            }
            else
            {
                hmotnostnakladu += naklad;
            }            
        }

        public void VylozNaklad(int naklad)
        {
            if(naklad > hmotnostnakladu)
            {                                
                MessageBox.Show(String.Format("Nemůžeš toho vyložit víc než máš naloženo!! Chybí {0} tun písku", naklad - hmotnostnakladu));
                hmotnostnakladu = 0;
            }
            else
            {
                hmotnostnakladu -= naklad;
            }
        }

        public override string ToString()
        {
            return "Nákladní auto a vlecka "+spz+" maji nosnost " + nosnost+"t a maji nalozeno " + HmotnostNakladu+ " tun";
        }

    }
}
