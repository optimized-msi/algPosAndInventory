using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Products
    {
        public string prodNo, prodName, prodDesc, category, buyPrice, addPrice, sellPrice, query;

        classDatabaseConnect dbcon = new classDatabaseConnect();
        public void InsertProduct()
        {
            if (IsDuplicateProdIdAndName())
                System.Windows.Forms.MessageBox.Show("Product ID/Name is existing. Please provide another one.", "Inventory");
            else
            {
                try
                {
                    query = "INSERT INTO products(product_ID,product_name,product_desc,product_price,product_addedprice,product_sellingprice,category_ID) VALUES('" + prodNo + "','" + prodName + "','" + prodDesc + "','" + buyPrice + "','" + addPrice + "','" + sellPrice + "',(SELECT category.category_ID FROM category WHERE category_name='"+category+"'))";
                    dbcon.ManipulateData(query);
                    System.Windows.Forms.MessageBox.Show("Added a product", "Inventory");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void UpdateProduct()
        {
            // to do: exempt the current prod id/name
            //if (IsDuplicateProdIdAndName())
            //    System.Windows.Forms.MessageBox.Show("Product ID/Name is existing. Please provide another one.", "Inventory");
            //else
            //{
                try
                {
                    query = "UPDATE products SET product_name='"+prodName+"',product_desc='"+prodDesc+"',product_price='"+buyPrice+"',product_addedprice='"+addPrice+"',product_sellingprice='"+sellPrice+"',category_ID=(SELECT category.category_ID FROM category WHERE category_name='" + category + "') WHERE product_ID='" + prodNo + "'";
                    dbcon.ManipulateData(query);
                    System.Windows.Forms.MessageBox.Show("Updated a product", "Inventory");
                }
                catch (Exception)
                {
                    throw;
                }
            //}
        }
        public void DeleteProduct()
        {
            string query = "DELETE FROM products WHERE product_ID='" + prodNo + "'";
            dbcon.ManipulateData(query);
            System.Windows.Forms.MessageBox.Show("Deleted a product", "Inventory");
        }
        public bool IsDuplicateProdIdAndName()
        {
            query = "SELECT product_ID, product_name FROM products WHERE product_ID='" + prodNo +"' OR product_name='"+ prodName +"'";
            if (dbcon.isDuplicate(query))
                return true;
            else
                return false;
        }
    }
}
