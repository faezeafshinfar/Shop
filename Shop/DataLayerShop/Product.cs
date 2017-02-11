using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerShop
{
    public class Product
    {
        public int ProductCode { get; set; }
        public string PersianTitle { get; set; }
        public string EnglishTitle { get; set; }
        public int AvailableCount { get; set; }
        public bool IsAvailable { get; set; }
        public string Producter { get; set; }
        public string FullExplain { get; set; }
        public string ShortExplain { get; set; }
        public int Price { get; set; }
        public char Buyer { get; set; }
        public char ProductDate { get; set; }
        public char ProductEditDate { get; set; }
        private DateTime RegisterDate { get; set; }    /*زمان ثبت*/

        public Product()   /*سازنده اصلی*/
        {
            this.RegisterDate= DateTime.Now.Date;
         
        }
        public Product(string persiantitle,string englishtitle,int availablecount,int price) /*سازنده اول*/
        {
            this.PersianTitle = persiantitle;
            this.EnglishTitle = englishtitle;
            this.AvailableCount = availablecount;
            this.Price = price;
            this.RegisterDate = DateTime.Now.Date;
        }
        public Product(string persiantitle,string englishtitle) /*سازنده دوم*/
        {
            this.PersianTitle = persiantitle;
            this.EnglishTitle = englishtitle;
            this.RegisterDate = DateTime.Now.Date;
        }

        public void AddAvailableCount(int AvailableCount)/*نابع افزایش موجودی محصول*/
        {
            this.AvailableCount+= AvailableCount;
           
        } 

        public void EditPrice(int NewPrice)/*تغییر قیمت محصول تنها توسط این تابع انجام می شود.*/
        {
            this.Price = NewPrice;
        }

    }
}
