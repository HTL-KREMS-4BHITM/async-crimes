using System.ComponentModel.DataAnnotations;

namespace Model.Entities;

public class AircraftSpecification
{
    [Key]
    public int SpecificationId { get; set; }
    [Required]
    public int Structure { get; set; }
    [Required]
    public int FuelTankCapacity { get; set; }
    [Required]
    public int MinSpeed { get; set; }
    [Required]
    public int MaxSpeed { get; set; }
    [Required]
    public int MaxAltitude { get; set; }
    [Required, MaxLength(45)]
    public string SpecificationCode { get; set; }
    public List<Aircraft> Aircrafts { get; set; }
}