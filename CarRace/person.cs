using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    public class person
    {
        public PictureBox CARPITURE;
        public int CARSTART;
        public int CARRACE;
        public int POSTION;
        public Random RANDOM;


        public void go()
        {
            this.CARPITURE.Left = 0;
            this.POSTION = 0;
        }
        public bool Raceing()
        {
            POSTION = RANDOM.Next(5);
            CARPITURE.Left += CARSTART + POSTION;

            if (CARPITURE.Left >= CARRACE)
                return true;

            return false;
        }
        

       
    }
}
