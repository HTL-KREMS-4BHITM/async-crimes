using System.ComponentModel.DataAnnotations;

namespace Model.Entities;

public class Mercenary
{
    [Key]
    public int MercenaryId { get; set; }
    [Required, MaxLength(45)]
    public string FirstName { get; set; }
    [Required, MaxLength(45)]
    public string LastName { get; set; }
    [Required]
    public int BodySkills { get; set; }
    [Required]
    public int CombatSkill { get; set; }
    public List<AircraftCrewJT> Aircrafts { get; set; }
    public List<MercenaryReputation> Reputations { get; set; }
}