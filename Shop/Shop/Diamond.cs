using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
  abstract class Diamond:EntityShape
    {
        public int BigCorner { get; set; }
        public int ShortCorner { get; set; }
        public Diamond( int bigCorner,int shortCorner)
        {
            BigCorner = bigCorner;
            ShortCorner = shortCorner;
        }
        public Diamond(int size)
        {
            Height = size;

        }
        public int Area()
        {
            return(BigCorner * ShortCorner / 2);
           
        }
        public int Mohit()
        {
            return (Height * 4);
           
        }

      
    }
}
