using System;

namespace Shop
{
    class Rectangle : EntityShape

    {
        public Rectangle(int hei, int wei)
        {
            if (hei != wei)
            {
                Width = wei;
                Height = hei;
            }
            else
            {
                throw new System.ArgumentException("طول و عرض نمی تواند یکسان باشد.", "دوباره وارد کنید.");
            }
        }
        public int Area()
        {
            return Height * Width;
        }
        public int Mohit()
        {
            return (Height*Width * 2);
        }
        public int Ghotr()
        {
            var i = Math.Pow(Height, 2);//arz be tavane 2
            var j = Math.Pow(Width, 2);//tool be tavane 2
            var z = i + j;//jam arz be tavane 2 va tool be tavane 2
            var result = Math.Pow(z, .5);// jazre jam arz be tavane 2 va tool be tavane 2

            return (int)result;
        }
    }
}