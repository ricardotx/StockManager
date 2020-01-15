﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Database.Models
{
  public class ProductLocation : BaseEntity
  {
    [Key]
    public int ProductLocationId { get; set; }

    public float Stock { get; set; }

    public float MinStock { get; set; }

    [Required(ErrorMessage = "ProductId is required")]
    [ForeignKey("Product")]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "LocationId is required")]
    [ForeignKey("Location")]
    public int LocationId { get; set; }

    public virtual Product Product { get; set; }
    public virtual Location Location { get; set; }
  }
}
