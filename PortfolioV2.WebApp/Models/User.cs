using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PortfolioV2.WebApp.Models;

[Table("users")]
[Index("Email", Name = "users_email_key", IsUnique = true)]
public partial class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("email")]
    public string Email { get; set; } = null!;

    [Column("role")]
    public string Role { get; set; } = null!;

    [Column("password_digest")]
    public string PasswordDigest { get; set; } = null!;
}
