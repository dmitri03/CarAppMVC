using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CarAppMVC.Models;

[Table("VehicleListing")]
public partial class VehicleListing
{
    [Key]
    [Column("_ID")]
    public long Id { get; set; }

    [Column("_URL")]
    [StringLength(180)]
    [Unicode(false)]
    public string Url { get; set; } = null!;

    [Column("_Make")]
    [MaxLength(20)]
    public byte[] Make { get; set; } = null!;

    [Column("_Model")]
    [StringLength(50)]
    [Unicode(false)]
    public string Model { get; set; } = null!;

    [Column("_Year")]
    public int Year { get; set; }

    [Column("_Price", TypeName = "money")]
    public decimal Price { get; set; }

    [Column("_Mileage")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Mileage { get; set; }

    [Column("_Location")]
    [StringLength(25)]
    [Unicode(false)]
    public string Location { get; set; } = null!;

    [Column("_Coordinates")]
    [StringLength(20)]
    [Unicode(false)]
    public string Coordinates { get; set; } = null!;

    [Column("_PriceStat")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PriceStat { get; set; }

    [Column("_DateAdded", TypeName = "date")]
    public DateTime DateAdded { get; set; }

    [Column("_isDealership")]
    [StringLength(10)]
    [Unicode(false)]
    public string IsDealership { get; set; } = null!;

    [Column("_Image1", TypeName = "image")]
    public byte[]? Image1 { get; set; }

    [Column("_Image2", TypeName = "image")]
    public byte[]? Image2 { get; set; }

    [Column("_Image3", TypeName = "image")]
    public byte[]? Image3 { get; set; }

    [Column("_Image4", TypeName = "image")]
    public byte[]? Image4 { get; set; }

    [Column("_Image5", TypeName = "image")]
    public byte[]? Image5 { get; set; }

    [Column("_Image6", TypeName = "image")]
    public byte[]? Image6 { get; set; }

    [Column("_Image7", TypeName = "image")]
    public byte[]? Image7 { get; set; }

    [Column("_Image8", TypeName = "image")]
    public byte[]? Image8 { get; set; }

    [Column("_Image9", TypeName = "image")]
    public byte[]? Image9 { get; set; }

    [Column("_Image10", TypeName = "image")]
    public byte[]? Image10 { get; set; }

    [Column("_Image11", TypeName = "image")]
    public byte[]? Image11 { get; set; }

    [Column("_Image12", TypeName = "image")]
    public byte[]? Image12 { get; set; }

    [Column("_ListingDetails")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ListingDetails { get; set; }

    [InverseProperty("Listing")]
    public virtual ICollection<WatchList> WatchLists { get; } = new List<WatchList>();
}
