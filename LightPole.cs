using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lights
{
    class LightPole
    {
        int range;
        int xposition;
        int yposition;


        public int Range
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
            }
        }
        public int Xposition
        {
            get
            {
                return xposition;
            }
            set
            {
                xposition = value;
            }
        }
        public int Ypostion
        {
            get
            {
                return yposition;
            }
            set
            {
                yposition = value;
            }
        }

        public LightPole(int range, int xposition, int ypostion)
        {
            this.range = range;
            this.xposition = xposition;
            this.yposition = ypostion;

        }



    }

}
