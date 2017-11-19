﻿using System;
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

    public List<Cart> GetOrdersInCart(string userID)
    {
        GarageDBEntities db = new GarageDBEntities();

        List<Cart> orders = (from x in db.Carts
                            where x.ClientId == userID
                            && x.IsInCart
                            orderby x.DatePurchased
                            select x).ToList();

        return orders;
    }

    public int GetAmountOfOrders(string userID)
    {
        try
        {
            GarageDBEntities db=new GarageDBEntities();

            int amount = (from x in db.Carts
                         where x.ClientId == userID
                         && x.IsInCart
                         select x.Amount).Sum();

            return amount;
        }
        catch (Exception)
        {
            return 0;
        }
    }

    public void UpdateQuantity(int id, int quantity)
    {
        GarageDBEntities db = new GarageDBEntities();

        Cart cart = db.Carts.Find(id);
        cart.Amount = quantity;

        db.SaveChanges();
    }

    public void MarkOrdersAsPaid(List<Cart> carts)
    {
        GarageDBEntities db = new GarageDBEntities();

        if (carts != null)
        {
            foreach (Cart cart in carts)
            {
                Cart oldCart = db.Carts.Find(cart.Id);
                oldCart.DatePurchased=DateTime.Now;
                oldCart.IsInCart = false;
            }
            db.SaveChanges();
        }
    }
}