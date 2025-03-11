using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("CRIME_SYNDICATES")]
public class CrimeSyndicate
{
    [Key, Column("SYNDICATE_ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SyndicateId { get; set; }
    
    [Column("NAME")]
    [Required, MaxLength(120)]
    public string Name { get; set; }
    
    [Column("LOCATION")]
    [Required, MaxLength(200)]
    public string Location { get; set; }
    [Column("MERCENARY_REPUTATION")]
    public List<MercenaryReputation> Mercenaries { get; set; }
}