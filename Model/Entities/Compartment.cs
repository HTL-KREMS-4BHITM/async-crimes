using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("COMPARTMENTS")]
public class Compartment
{
    [Key, Column("COMPARTMENT_ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CompartmentId { get; set; }
    
    
    [ForeignKey("AIRCRAFT_ID")]
    public int AircraftId { get; set; }
    public Aircraft Aircraft { get; set; }
    public List<Machinery> Machineries { get; set; }
    [Column("NAME")]
    public string Name { get; set; }
}