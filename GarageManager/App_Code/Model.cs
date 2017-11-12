﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class AspNetRole
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AspNetRole()
    {
        this.AspNetUsers = new HashSet<AspNetUser>();
    }

    public string Id { get; set; }
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
}

public partial class AspNetUser
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AspNetUser()
    {
        this.AspNetUserClaims = new HashSet<AspNetUserClaim>();
        this.AspNetUserLogins = new HashSet<AspNetUserLogin>();
        this.AspNetRoles = new HashSet<AspNetRole>();
    }

    public string Id { get; set; }
    public string Email { get; set; }
    public bool EmailConfirmed { get; set; }
    public string PasswordHash { get; set; }
    public string SecurityStamp { get; set; }
    public string PhoneNumber { get; set; }
    public bool PhoneNumberConfirmed { get; set; }
    public bool TwoFactorEnabled { get; set; }
    public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
    public bool LockoutEnabled { get; set; }
    public int AccessFailedCount { get; set; }
    public string UserName { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
}

public partial class AspNetUserClaim
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string ClaimType { get; set; }
    public string ClaimValue { get; set; }

    public virtual AspNetUser AspNetUser { get; set; }
}

public partial class AspNetUserLogin
{
    public string LoginProvider { get; set; }
    public string ProviderKey { get; set; }
    public string UserId { get; set; }

    public virtual AspNetUser AspNetUser { get; set; }
}

public partial class C__MigrationHistory
{
    public string MigrationId { get; set; }
    public string ContextKey { get; set; }
    public byte[] Model { get; set; }
    public string ProductVersion { get; set; }
}

public partial class Cart
{
    public int Id { get; set; }
    public string ClientId { get; set; }
    public int ProductId { get; set; }
    public int Amount { get; set; }
    public Nullable<System.DateTime> DatePurchased { get; set; }
    public bool IsInCart { get; set; }

    public virtual Product Product { get; set; }
}

public partial class Product
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Product()
    {
        this.Carts = new HashSet<Cart>();
    }

    public int Id { get; set; }
    public int TypeId { get; set; }
    public string Name { get; set; }
    public Nullable<int> Price { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Cart> Carts { get; set; }
    public virtual ProductType ProductType { get; set; }
}

public partial class ProductType
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ProductType()
    {
        this.Products = new HashSet<Product>();
    }

    public int Id { get; set; }
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Product> Products { get; set; }
}

public partial class sysdiagram
{
    public string name { get; set; }
    public int principal_id { get; set; }
    public int diagram_id { get; set; }
    public Nullable<int> version { get; set; }
    public byte[] definition { get; set; }
}

public partial class UserInformation
{
    public int ID { get; set; }
    public string GUID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int PostalCode { get; set; }
}
