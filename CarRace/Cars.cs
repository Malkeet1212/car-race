using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    class RACERS
    {
        public int AMOUNTRACER;
        public RadioButton RADIOBTNS;
        public Label LABLS;
        public string RACERNAME;
        public BETTING MONEYONCAR;
        

      


        public void CANCELBET()
        {
            MONEYONCAR.MONEY = 0;
        }
        public RACERS(string BETTERNAME, int MONEY, RadioButton BTNRADIOS, Label LABELS)
        {
            RACERNAME = BETTERNAME;
            AMOUNTRACER = MONEY;
            LABLS = LABELS;
            MONEYONCAR = new BETTING(this);
            RADIOBTNS = BTNRADIOS;
            
        }
        public bool BETAMOUNT(int mONEY, int FIRST)
        {
            MONEYONCAR.MONEY = mONEY;
            MONEYONCAR.CARS = FIRST;
            if (AMOUNTRACER >= mONEY) return true;
            return false;
        }
        public void CARWINNER(int WINNED)
        {
            AMOUNTRACER += MONEYONCAR.RACEFINISH(WINNED);
            CANCELBET();
            LABELSUPDATESCAR();
        }
        public void LABELSUPDATESCAR()
        {
            LABLS.Text = MONEYONCAR.PAcedbet();
            RADIOBTNS.Text = RACERNAME + " has " + AMOUNTRACER + " $";
        }
       
    }
}
