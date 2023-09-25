using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("tb_tr_bookings")]//nama tabel
public class Booking : BaseEntity
{    
    [Column("start_date")]//membuat kolom 
    public DateTime StartDate { get; set; }    
    [Column("status")]//membuat kolom
    public StatusLevel Status { get; set; }   
    [Column("remarks", TypeName = "nvarchar")]//membuat kolom
    public string Remarks { get; set; }    
    [ForeignKey("Room"), Column("room_guid")]//membuat kolom
    public Guid RoomGuid { get; set; }    
    [ForeignKey("Employee"), Column("employee_id")]//membuat kolom
    public Guid EmployeeGuid { get; set; }

}
