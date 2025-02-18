using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("ENERGY_SYSTEMS")]
public class EnergySystem
{
    [Key, Column("MACHINERY_ID")]
    public int MachineryId { get; set; }
    public Machinery Machinery { get; set; }
}