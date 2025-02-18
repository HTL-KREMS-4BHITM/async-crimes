using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;
[Table("MERCENARY")]
public class Mercenary
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("MERCENARY_ID")]
    public int MercenaryId { get; set; }
    [Required, MaxLength(45), Column("FIRST_NAME")]
    public string FirstName { get; set; }
    [Required, MaxLength(45), Column("LAST_NAME")]
    public string LastName { get; set; }
    [Required,Column("BODY_SKILLS")]
    public int BodySkills { get; set; }
    [Required, Column("COMBAT_SKILLS")]
    public int CombatSkill { get; set; }
    public List<AircraftCrewJT> Aircrafts { get; set; }
    public List<MercenaryReputation> Reputations { get; set; }
}