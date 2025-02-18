using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("AIRCRAFT")]
public class Aircraft
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AircraftId { get; set; }
    [ForeignKey("Specification")]
    public int SpecificationId { get; set; }
    [Required, MaxLength(100)]
    public string Fuel { get; set; }
    [Required]
    public int Speed { get; set; }
    [Required]
    public int Altitude { get; set; }
    [Required, MaxLength(200)]
    public string Name { get; set; }
    public AircraftSpecification Specification { get; set; }
    public List<Compartment> Compartments { get; set; }
    public List<AircraftCrewJT> CrewMembers { get; set; }
}