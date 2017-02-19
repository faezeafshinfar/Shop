using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    abstract class Diamond : EntityShape
    {
        public float BigCorner { get; set; } //zaviye bozorg
        public float ShortCorner { get; set; } //zaviye kochik
        public Diamond(float Big, float Short)
        {
                BigCorner = Big;
                ShortCorner = Short;  
        }
        public Diamond(int size)
        {
            Height = size;

        }
        public void OtherCorner(float corner1 )
        {
            float corner2;
            corner2 = 180 - corner1;
            if (corner1 > corner2)
            {
                BigCorner = corner1;
                ShortCorner = corner2;
            }
            else
            {
                BigCorner = corner2;
                ShortCorner = corner1;
            }
        }
        public float Area()
        {
            return ( BigCorner * ShortCorner / 2);

        }
        public int Mohit()//in mohiteshe
        {
            return (Height * 4);

        }
        //public  BigGhotr()
        //{
        //    return 2 * Height * Math.Sin(BigCorner / 2);

        //}
    }
}
