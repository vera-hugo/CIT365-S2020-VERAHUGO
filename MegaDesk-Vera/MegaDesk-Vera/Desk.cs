using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MegaDesk_Vera

{
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    public static class variablesConstraints
    { 
    public const int MINWIDTH = 24;
    public const int MAXWIDTH = 96;
    public const int MINDEPTH = 12;
    public const int MAXDEPTH = 48;

    }
    public  class Desk
    {
        
        //bject with width, depth, number of drawers, and the surface material
        public  int widthDesk;
        public  int depthDesk;
        public  int drawersDesk;
        public DesktopMaterial myDesktopMaterial;



        //public const int constanTest = 1000;

        public Desk()
        {

        }

        public Desk(int widthDesk, int depthDesk, int drawersDesk, DesktopMaterial surfaceMaterial) 
        {
            this.widthDesk = widthDesk;
            this.depthDesk = depthDesk;
            this.drawersDesk = drawersDesk;
            this.myDesktopMaterial = surfaceMaterial;
        
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

        public void setsurfaceMaterial(DesktopMaterial surfaceMaterial)
        {
            this.myDesktopMaterial = surfaceMaterial;
        }

        public DesktopMaterial getsurfaceMaterial()
        {
                return this.myDesktopMaterial;
        }

        public int getMINWIDTH()
        {
            return variablesConstraints.MINWIDTH;
        }

        public int getMAXWIDTH()
        {
            return variablesConstraints.MAXWIDTH;
        }

        public int getMINDEPTH()
        {
            return variablesConstraints.MINDEPTH;
        }

        public int getMAXDEPTH()
        {
            return variablesConstraints.MAXDEPTH;
        }


    }
}
