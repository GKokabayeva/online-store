﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

public partial class Pages_Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            string clientId = Context.User.Identity.GetUserId();

            if (clientId != null)
            {

                int id = Convert.ToInt32(Request.QueryString["id"]);
                int amount = Convert.ToInt32(ddlAmount.SelectedValue);

                Cart cart = new Cart()
                {
                    Amount = amount,
                    ClientId = clientId,
                    DatePurchased = DateTime.Now,
                    IsInCart = true,
                    ProductId = id
                };

                CartModel model = new CartModel();
                model.InsertCart(cart);
                lblResult.Text = "Order was successfully inserted to your cart";
            }
            else
            {
                lblResult.Text = "Please, log in to order items";
            }
        }
    }

    private void FillPage()
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ProductModel productModel = new ProductModel();
            Product product = productModel.GetProduct(id);

            lblPrice.Text = "Price per unit: <br/>$ " + product.Price;
            lblTitle.Text = product.Name;
            lblDescription.Text = product.Description;
            lblItemNr.Text = product.Id.ToString();
            imgProduct.ImageUrl = "~/Images/Products/" + product.Image;

            int[] amount = Enumerable.Range(1, 20).ToArray();
            ddlAmount.DataSource = amount;
            ddlAmount.AppendDataBoundItems = true;
            ddlAmount.DataBind();
        }
    }
}