using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;


[Table("tb_m_accounts")]//membuat nama tabel
public class Account : BaseEntity
{
    
    [Column("password", TypeName = "nvarchar")]//membuat kolom dan tipe data
    public string Password { get; set; }    
    [Column("otp")]//membuat kolom dan tipe data
    public int OTP { get; set; }   
    [Column("is_used")]//membuat kolom dan tipe data
    public bool IsUsed { get; set; }    
    [Column("expired_time")]//membuat kolom dan tipe data
    public DateTime ExpiredTime { get; set; }

}
