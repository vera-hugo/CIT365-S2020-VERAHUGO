using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Vera
{
    class DeskQuote
    {
        /*private int widthDesk;
        private int depthDesk;
        private int drawersDesk;
        private string surfaceMaterial;*/
        public Desk myDesk = new Desk();
        

        
        

        // rush days, customer name, and quote date
        private int dayRush;
        private string customerName;
        private DateTime date;



        public DeskQuote(Desk myDesk, int dayRush, string customerName, DateTime date)
        {
            
            this.myDesk = myDesk;
            this.dayRush = dayRush;
            this.customerName = customerName;
            this.date = date;

        }

        private void setmyDesk(Desk myDesk)
        {
            this.myDesk = myDesk;
        }

        public Desk getmyDesk()
        {
            return this.myDesk;
        }

        private void setdayRush(int dayRush)
        {
            this.dayRush = dayRush;
        }

        public int getdayRush()
        {
            return this.dayRush;
        }

        private void setcustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public string getcustomerName()
        {
            return this.customerName;
        }

        private void setdate(DateTime date)
        {
            this.date = date;
        }

        public DateTime getdate()
        {
            return this.date;
        }

       

        
        
    }
}
