using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;   
    [Table("tb_m_account_roles")]//membuat nama tabel
public class AccountRole : BaseEntity
    {        
        [ForeignKey("Account"), Column("account_guid")]//membuat kolom dan tipe data
    public Guid AccountGuid { get; set; }        
        [ForeignKey("Role"), Column("role_guid")]//membuat kolom dan tipe data
    public Guid RoleGuid { get; set; }
    }

