using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();

            db.Carts.Add(cart);

            db.SaveChanges();

            return cart.DatePurchased + " was successfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();

            Cart c = db.Carts.Find(id);

            c.ClientId = cart.ClientId;
            c.IsInCart = cart.IsInCart;
            c.ProductId = cart.ProductId;
            c.Amount = cart.Amount;
            c.DatePurchased = cart.DatePurchased;

            db.SaveChanges();

            return cart.DatePurchased + " was successfully updated";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string DeleteCart(int id)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();

            Cart cart = db.Carts.Find(id);

            db.Carts.Attach(cart);
            db.Carts.Remove(cart);

            db.SaveChanges();

            return cart.DatePurchased + " was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
}