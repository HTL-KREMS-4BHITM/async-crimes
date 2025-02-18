using System.ComponentModel.DataAnnotations;

namespace Model.Entities;

public class CrimeSyndicate
{
    [Key]
    public int SyndicateId { get; set; }
    [Required, MaxLength(120)]
    public string Name { get; set; }
    [Required, MaxLength(200)]
    public string Location { get; set; }
    public List<MercenaryReputation> Mercenaries { get; set; }
}