using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("AIRCRAFTS")]
public class Aircraft
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required, Column("AIRCRAFT_ID")]
    public int AircraftId { get; set; }
    [ForeignKey("SPEZIFICATION_ID")]
    public int SpecificationId { get; set; }
    
    [Column("FUEL")]
    [Required, MaxLength(100)]
    public string Fuel { get; set; }
    
    [Column("SPEED")]
    [Required]
    public int Speed { get; set; }
    
    [Column("ALTITUDE")]
    [Required]
    public int Altitude { get; set; }
    
    [Column("NAME")]
    [Required, MaxLength(200)]
    public string Name { get; set; }
    public AircraftSpecification Specification { get; set; }
    public List<Compartment> Compartments { get; set; }
    public List<AircraftCrewJT> CrewMembers { get; set; }
}