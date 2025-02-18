using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("WEAPONS")]
public class Weapon
{
    [Column("MACHINERY_ID")]
    public int MachineryId { get; set; }
    [Column("MACHINERY")]
    public Machinery Machinery { get; set; }
}