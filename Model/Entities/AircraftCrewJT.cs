using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class AircraftCrewJT
{
    [Column("AIRCRAFT_ID"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AircraftId { get; set; }
    public Aircraft Aircraft { get; set; }
    
    [ForeignKey("MERCENARY_ID")]
    public int MercenaryId { get; set; }
    public Mercenary Mercenary { get; set; }
    
    [Column("JOINED_AT")]
    [Required]
    public DateTime JoinedAtDate { get; set; }
}