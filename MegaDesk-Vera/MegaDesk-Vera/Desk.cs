using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Vera
{
    class Desk
    {
        
        //bject with width, depth, number of drawers, and the surface material
        private int widthDesk;
        private int depthDesk;
        private int drawersDesk;
        private string surfaceMaterial;

        private  int MINWIDTH = 24;
        private  int MAXWIDTH = 96;
        private  int MINDEPTH = 12;
        private  int MAXDEPTH = 48;

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

        private void setwidthDesk(int witdhDesk) 
        {
            this.widthDesk = witdhDesk;
        }

        public int getwidthDesk()
        {
            return this.widthDesk;
        }

        private void setdepthDesk(int depthDesk)
        {
            this.depthDesk = depthDesk;
        }
        public int getdepthDesk()
        {
                return this.depthDesk;
        }


        private void setdrawersDesk(int drawersDesk)
        {
            this.drawersDesk = drawersDesk;
        }

        public int getdrawersDesk()
        {
                return this.drawersDesk;
        }

        private void setsurfaceMaterial(string surfaceMaterial)
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
