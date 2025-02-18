using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class EnergySystem
{
    [Key, ForeignKey("Machinery")]
    public int MachineryId { get; set; }
    public Machinery Machinery { get; set; }
}