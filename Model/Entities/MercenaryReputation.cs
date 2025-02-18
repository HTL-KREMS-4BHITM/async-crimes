using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class MercenaryReputation
{
    [ForeignKey("CrimeSyndicate")]
    public int SyndicateId { get; set; }
    public CrimeSyndicate Syndicate { get; set; }
    [ForeignKey("Mercenary")]
    public int MercenaryId { get; set; }
    public Mercenary Mercenary { get; set; }
    [Required, MaxLength(45)]
    public string ReputationChange { get; set; }
}