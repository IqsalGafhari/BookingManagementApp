using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

[Table("tb_m_university")]//membuat nama tabel
public class University : BaseEntity//inheritance
{  
    [Column("code", TypeName = "nvarchar(50)")]//membuat kolom 
    public string Code { get; set; }    
    [Column("name", TypeName = "nvarchar(100)")]//membuat kolom 
    public string Name { get; set; }
}
