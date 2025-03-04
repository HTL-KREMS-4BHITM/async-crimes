﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("MERCENARY_REPUTATIONS")]
public class MercenaryReputation
{
    [Column("SYNDICATE_ID")]
    public int SyndicateId { get; set; }
    public CrimeSyndicate Syndicate { get; set; }
    
    [Column("MERCENARY_ID")]
    public int Mercenary_Id { get; set; }
    public Mercenary Mercenary { get; set; }
    
    [Required, MaxLength(45), Column("REPUTATION_CHANGE")]
    public string ReputationChange { get; set; }
}