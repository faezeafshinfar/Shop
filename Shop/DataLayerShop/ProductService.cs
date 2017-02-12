using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerShop
{
    public class ProductServices
    {
        private Product[] ArrayOfProducts;/*ارایه ای از محصولات*/
        private int AvailableProductCount { get; set; }


        public ProductServices() { AvailableProductCount = 0; }
        ~ProductServices()
        {
            foreach (var item in ArrayOfProducts)/*تمام موجودی رو صفر میکنه*/
            {
                item.AvailableCount = 0;
            }
        }
        public bool AddProduct(Product temp)/*تابع افزودن محصول به آرایه ورودی از نوع محصول میگیره*/
        {
            try
            {
                ProductServices temps = new DataLayerShop.ProductServices();
                temps.ArrayOfProducts[temps.AvailableProductCount] = temp;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool RemoveProduct(int temp)/*تابع حذف محصول */
        {
            try
            {
                ProductServices temps = new DataLayerShop.ProductServices();
                temps.ArrayOfProducts = ArrayOfProducts.Where(i => i.ProductCode != temp).ToArray();/*همه ی محصولات رو غیر از اونی که میخواد حذف شه می ریزه داخل یک متغیر*/
                ArrayOfProducts = temps.ArrayOfProducts;/*همه ی محصولات غیر اونی که میخواد حذف شه*/
                AvailableProductCount -= 1;/*یکی کم می کنه از تعداد محصولات*/
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Product ExpensiveProduct()
        {
            Product temp = new DataLayerShop.Product();
            temp = ArrayOfProducts.Single(j => j.Price == ArrayOfProducts.Max(i => i.Price));/*گران ترین محصول رو با سلکتور سلکت می کنه همون ماکسیمم می ریزه تو تمپ*/
            return temp;/*گران ترین محصول رو برگردوند*/
        }
        public Product[] GetProducts()
        {
            return ArrayOfProducts;/*ارایه ای از تعداد محصولات بر میگردونه*/
        }
        public Product this[int index]/*ایندکسر*/
        {
            get
            {
                return ArrayOfProducts.Single(i => i.ProductCode == index);
            }
            set
            {
                ArrayOfProducts[index] = value;
            }
        }

    }
}
