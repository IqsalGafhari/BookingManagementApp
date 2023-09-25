using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

    public class BaseEntity
    {        
        [Key, Column("guid")]//primary key 
    public Guid Guid { get; set; }        
        [Column("created_date")]//membuat kolom 
    public DateTime CreatedDate { get; set; } = DateTime.Now;      
        [Column("modified_date")]//membuat kolom 
    public DateTime ModifiedDate { get; set; }
    }

