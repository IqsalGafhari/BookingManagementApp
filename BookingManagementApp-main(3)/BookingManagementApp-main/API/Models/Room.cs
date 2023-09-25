using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("tb_m_rooms")]//membuat nama tabel
public class Room : BaseEntity
{    
    [Column("name", TypeName = "nvarchar(100)")] //membuat kolom 
    public string Name { get; set; }    
    [Column("floor")]//membuat kolom 
    public int Floor { get; set; }    
    [Column("capacity")]//membuat kolom 
    public int Capacity { get; set; }
}
