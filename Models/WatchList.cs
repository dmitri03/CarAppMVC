using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CarAppMVC.Models;

[Table("WatchList")]
public partial class WatchList
{
    [Key]
    [Column("_WatchlistID")]
    public int WatchlistId { get; set; }

    [Column("_UserID")]
    public int? UserId { get; set; }

    [Column("_WatchlistName")]
    [StringLength(20)]
    [Unicode(false)]
    public string WatchlistName { get; set; } = null!;

    [Column("_ListingID")]
    public long ListingId { get; set; }

    [Column("_Model")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Model { get; set; }

    [Column("_Make")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Make { get; set; }

    [Column("_Year")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Year { get; set; }

    [Column("_Price", TypeName = "money")]
    public decimal? Price { get; set; }

    [Column("_Location")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("_FirstImage", TypeName = "image")]
    public byte[]? FirstImage { get; set; }

    [ForeignKey("ListingId")]
    [InverseProperty("WatchLists")]
    public virtual VehicleListing Listing { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("WatchLists")]
    public virtual UserAccount? User { get; set; }
}
