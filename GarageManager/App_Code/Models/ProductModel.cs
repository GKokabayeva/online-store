using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductModel
/// </summary>
public class ProductModel
{
    public string InsertProduct(Product product)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();

            db.Products.Add(product);

            db.SaveChanges();

            return product.Name + " was successfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string UpdateProduct(int id, Product product)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();

            Product p = db.Products.Find(id);

            p.Name = product.Name;
            p.Description = product.Description;
            p.Price = product.Price;
            p.TypeId = product.TypeId;
            p.Image = product.Image;

            db.SaveChanges();

            return product.Name + " was successfully updated";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string DeleteProduct(int id)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();

            Product product = db.Products.Find(id);

            db.Products.Attach(product);
            db.Products.Remove(product);

            db.SaveChanges();

            return product.Name + " was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}