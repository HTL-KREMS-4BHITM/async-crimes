using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("AIRCRAFT_CREW_JT")]
public class AircraftCrewJT
{
    [Column("AIRCRAFT_ID")]
    public int Aircraft_Id { get; set; }
    public Aircraft Aircraft { get; set; }
    
    [ForeignKey("MERCENARY_ID")]
    public int Mercenary_Id { get; set; }
    public Mercenary Mercenary { get; set; }
    
    [Column("JOINED_AT")]
    [Required]
    public DateTime JoinedAtDate { get; set; }
}