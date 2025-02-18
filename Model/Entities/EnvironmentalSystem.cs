using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("ENVIRONMENTAL_SYSTEM")]
public class EnvironmentalSystem
{
    [Key, Column("MACHINERY_ID")]
    public int MachineryId { get; set; }
    public Machinery Machinery { get; set; }
}