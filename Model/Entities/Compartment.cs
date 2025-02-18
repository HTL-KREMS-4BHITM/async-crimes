using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class Compartment
{
    [Key]
    public int CompartmentId { get; set; }
    [ForeignKey("Aircraft")]
    public int AircraftId { get; set; }
    public Aircraft Aircraft { get; set; }
    public List<Machinery> Machineries { get; set; }
}