using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("AIRCRAFT_SPECIFICATIONS")]
public class AircraftSpecification
{
    [Key, Column("SPEZIFICATION_ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SpecificationId { get; set; }
    
    [Column("STRUCTURE")]
    [Required]
    public int Structure { get; set; }
    
    [Column("FUEL_TANK_CAPACITY")]
    [Required]
    public int FuelTankCapacity { get; set; }
    
    [Column("MIN_SPEED")]
    [Required]
    public int MinSpeed { get; set; }
    
    [Column("MAX_SPEED")]
    [Required]
    public int MaxSpeed { get; set; }
    
    [Column("MAX_ALTITUDE")]
    [Required]
    public int MaxAltitude { get; set; }
    
    [Column("SPECIFICATION_CODE")]
    [Required, MaxLength(45)]
    public string SpecificationCode { get; set; }
    public List<Aircraft> Aircrafts { get; set; }
}