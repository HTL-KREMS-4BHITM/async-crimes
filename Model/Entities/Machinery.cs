using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class Machinery
{
    [Key]
    public int MachineryId { get; set; }
    [Required, MaxLength(45)]
    public string Label { get; set; }
    public string Function { get; set; }
    [ForeignKey("Compartment")]
    public int CompartmentId { get; set; }
    public Compartment Compartment { get; set; }
    public Weapon Weapon { get; set; }
    public EnergySystem EnergySystem { get; set; }
    public EnvironmentalSystem EnvironmentalSystem { get; set; }
}