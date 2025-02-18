using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class AircraftCrewJT
{
    [ForeignKey("Aircraft")]
    public int AircraftId { get; set; }
    public Aircraft Aircraft { get; set; }
    [ForeignKey("Mercenary")]
    public int MercenaryId { get; set; }
    public Mercenary Mercenary { get; set; }
    [Required]
    public DateTime JoinedAtDate { get; set; }
}