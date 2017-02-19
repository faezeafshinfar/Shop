using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Squere : EntityShape
    {
        public Squere(int wei, int hei)
        {
            if (hei == wei)
            {
                Width = wei;
                Height = hei;
            }
            else
            {
                throw new System.ArgumentException("طول و عرض نمی تواند یکسان نباشد.", "دوباره وارد کنید.");

            }
        }

        public int Area()
        {
            return (Height * Width); 
        }
        public int Mohit()
        {
            return (Height * 4);
        }
       public int Ghotr()
        {            
            int result = base.Height*Width/ Height;
            return (result);
        }

    }
}

