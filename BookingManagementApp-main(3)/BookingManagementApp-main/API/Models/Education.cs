using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;


[Table("tb_m_educations")]//nama tabel
public class Education : BaseEntity
{    
    [Column("major", TypeName = "nvarchar(100)")]//membuat kolom 
    public string Major { get; set; }   
    [Column("degree", TypeName = "nvarchar(100)")]//membuat kolom 
    public string Degree { get; set; }   
    [Column("gpa")]//membuat kolom 
    public float GPA { get; set; }    
    [ForeignKey("University"), Column("university_guid")]//membuat kolom 
    public Guid UniversityGuid { get; set; }

}
