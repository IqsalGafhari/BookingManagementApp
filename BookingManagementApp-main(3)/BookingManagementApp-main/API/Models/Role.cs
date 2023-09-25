using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    
    [Table("tb_m_roles")]//membuat nama tabel
    public class Role : BaseEntity
    {        
        [Column("name", TypeName = "nvarchar(100)")]//membuat kolom dan tipe data
        public string Name { get; set; }
    }
}
