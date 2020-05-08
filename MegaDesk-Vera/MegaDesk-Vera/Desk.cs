using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Vera
{
    public class Desk
    {
        
        //bject with width, depth, number of drawers, and the surface material
        public  int widthDesk;
        public  int depthDesk;
        public  int drawersDesk;
        public  string surfaceMaterial;

        public  int MINWIDTH = 24;
        public  int MAXWIDTH = 96;
        public  int MINDEPTH = 12;
        public  int MAXDEPTH = 48;

        //public const int constanTest = 1000;

        public Desk()
        {

        }

        public Desk(int widthDesk, int depthDesk, int drawersDesk, string surfaceMaterial) 
        {
            this.widthDesk = widthDesk;
            this.depthDesk = depthDesk;
            this.drawersDesk = drawersDesk;
            this.surfaceMaterial = surfaceMaterial;
        
        }

        public void setwidthDesk(int witdhDesk) 
        {
            this.widthDesk = witdhDesk;
        }

        public int getwidthDesk()
        {
            return this.widthDesk;
        }

        public void setdepthDesk(int depthDesk)
        {
            this.depthDesk = depthDesk;
        }
        public int getdepthDesk()
        {
                return this.depthDesk;
        }


        public void setdrawersDesk(int drawersDesk)
        {
            this.drawersDesk = drawersDesk;
        }

        public int getdrawersDesk()
        {
                return this.drawersDesk;
        }

        public void setsurfaceMaterial(string surfaceMaterial)
        {
            this.surfaceMaterial = surfaceMaterial;
        }

        public string getsurfaceMaterial()
        {
                return this.surfaceMaterial;
        }

        public int getMINWIDTH()
        {
            return this.MINWIDTH;
        }

        public int getMAXWIDTH()
        {
            return this.MAXWIDTH;
        }

        public int getMINDEPTH()
        {
            return this.MINDEPTH;
        }

        public int getMAXDEPTH()
        {
            return this.MAXDEPTH;
        }


    }
}
