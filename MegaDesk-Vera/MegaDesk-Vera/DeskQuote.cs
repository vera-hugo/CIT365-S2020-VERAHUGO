using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Reflection;

namespace MegaDesk_Vera
{
    class jsonVariables
    {
        public string CustomeName { get; set; }
        public DateTime date { get; set; }

        public int basePrice { get; set; }
       
        public int rushDay { get; set; }

        public DesktopMaterial surfaceMaterial { get; set; }

        public int numberOfDrawers { get; set; }
        
        public int width { get; set; }

        public int depth { get; set; }

        public int surfaceArea { get; set; }

        public float totalCost { get; set; }



        public jsonVariables(DeskQuote myDeskQuote) 
        {
            CustomeName = myDeskQuote.getcustomerName();
            date = myDeskQuote.getdate();
            basePrice = myDeskQuote.getBaseCost();
            rushDay = myDeskQuote.getdayRush();
            surfaceMaterial = myDeskQuote.getmyDesk().getsurfaceMaterial();
            numberOfDrawers = myDeskQuote.getmyDesk().getdrawersDesk();
            width = myDeskQuote.getmyDesk().getwidthDesk();
            depth = myDeskQuote.getmyDesk().getdepthDesk();
            surfaceArea = myDeskQuote.getArea();
            totalCost = myDeskQuote.finalCost();
        }
    }
    class DeskQuote
    {

        private Desk myDesk = new Desk();
        public const int baseCost = 200;


        private int dayRush;
        private string customerName;
        private DateTime date;

        public int[,] orderDays = new int[3, 3];


        public DeskQuote() 
        {
        
        }

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

        public int getArea() 
        {
            return myDesk.getwidthDesk() * myDesk.getdepthDesk(); 

        }

        public int getBaseCost()
        {
            return baseCost;

        }

        public int getextraAreaCost()
        
        {
            return getArea() > 1000 ? getArea() - 1000 : 0;        
        }

        public int getsurfaceMaterialCost()

        {
            int cost = 0;

            switch (myDesk.getsurfaceMaterial()) 
                      
            {
                case DesktopMaterial.Oak:

                    cost = 200;

                    break;
                case DesktopMaterial.Laminate:

                    cost = 100;

                    break;
                case DesktopMaterial.Pine:

                    cost = 50;

                    break;
                case DesktopMaterial.Rosewood:

                    cost = 300;

                    break;
                case DesktopMaterial.Veneer:

                    cost = 125;

                    break;

            }

            return cost;
        }

        public int getdrawersCost() 
        {

            return getmyDesk().getdrawersDesk() * 50;
        
        }

        public int getrushCost() 
        {
            int cost = 0;

            switch (getdayRush())

            {
                case 3:

                    if (getArea() < 1000)

                        cost = 60;

                    else if (getArea() < 2001)
                        cost = 70;

                    else cost = 80;

                 break;
                case 5:

                    if (getArea() < 1000)

                        cost = 40;

                    else if (getArea() < 2001)
                        cost = 50;

                    else cost = 60;

                 break;
                case 7:

                    if (getArea() < 1000)

                        cost = 30;

                    else if (getArea() < 2001)
                        cost = 35;

                    else cost = 40;

                break;
                case 14:

                    cost = 0;

                 break;
              
            }

            return cost;

        }

        public float finalCost() 
        {

            return getrushCost() + getdrawersCost() + getsurfaceMaterialCost() + getextraAreaCost() + getBaseCost();
        }

        public int GetRushOrder() 
                    
        {
            string[] readText = new string[9];
            try
            {
               readText = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "\\rushOrderPrices.txt"), Encoding.UTF8);

            }

            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:" + e.Message);

            }

            for (int index = 0; index < readText.Length; index++)
            {               
                
               this.orderDays[index % 3, index / 3] = Convert.ToInt32(readText[index]);               
            }
            return  0;            
        }


    }
}
