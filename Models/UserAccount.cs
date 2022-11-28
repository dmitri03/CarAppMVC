using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CarAppMVC.Models;

[Table("UserAccount")]
public partial class UserAccount
{
    [Key]
    [Column("_ID")]
    public int Id { get; set; }

    [Column("_FirstName")]
    [StringLength(20)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [Column("_LastName")]
    [StringLength(20)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [Column("_Email")]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("_PhoneNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [Column("_Location")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Location { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<WatchList> WatchLists { get; } = new List<WatchList>();
}
