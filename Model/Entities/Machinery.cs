using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("MACHINERIES")]
public class Machinery
{
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("MACHINERY_ID")]
    public int MachineryId { get; set; }
    [Required, MaxLength(45), Column("LABEL")]
    public string Label { get; set; }
    [Column("FUNCTION"), DataType(DataType.Text)]
    public string Function { get; set; }
    [Column("COMPARTMENT_ID")]
    public int CompartmentId { get; set; }
    public Compartment Compartment { get; set; }
    public Weapon Weapon { get; set; }
    public EnergySystem EnergySystem { get; set; }
    public EnvironmentalSystem EnvironmentalSystem { get; set; }
}