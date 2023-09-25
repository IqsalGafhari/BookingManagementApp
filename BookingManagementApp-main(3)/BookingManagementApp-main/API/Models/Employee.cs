using API.Utilities.Enum;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("tb_m_employees")]//nama tabel
public class Employee : BaseEntity
{
    [Column("nik", TypeName = "nchar(6)")]//membuat kolom 
    public string NIK { get; set; }
    [Column("first_name", TypeName = "nvarchar(100)")]//membuat kolom 
    public string FirstName { get; set; }
    [Column("last_name", TypeName = "nvarchar(100)")]//membuat kolom 
    public string? LastName { get; set; }
    [Column("birth_date")]//membuat kolom 
    public DateTime BirthDate { get; set; }
    [Column("gender")]//membuat kolom 
    public Gender Gender { get; set; }
    [Column("hiring_date")]//membuat kolom 
    public DateTime HiringDate { get; set; }    
    [Column("email", TypeName = "nvarchar(100)")]//membuat kolom 
    public string Email { get; set; }
    [Column("phone_number", TypeName = "nvarchar(20)")]//membuat kolom 
    public string phoneNumber { get; set; }
}
