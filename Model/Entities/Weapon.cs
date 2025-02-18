using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("WEAPONS")]
public class Weapon
{
    [Column("MACHINERY_ID"), Key]
    public int MachineryId { get; set; }
    public Machinery Machinery { get; set; }
}