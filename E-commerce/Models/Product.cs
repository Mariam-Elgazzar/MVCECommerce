﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Models;

[Table("Product")]
public partial class Product
{
    [Key]
    public int id { get; set; }

    [Required]
    [StringLength(255)]
    public string name { get; set; }

    [Column(TypeName = "text")]
    public string description { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal price { get; set; }

    public int? catid { get; set; }

    public string photo { get; set; }

    [InverseProperty("product")]
    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    [ForeignKey("catid")]
    [InverseProperty("Products")]
    public virtual Category cat { get; set; }
}