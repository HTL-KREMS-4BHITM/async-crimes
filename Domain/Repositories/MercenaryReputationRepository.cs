using Model;
using Model.Entities;

namespace Domain.Repositories;

public class MercenaryReputationRepository : ARepositoryAsync<MercenaryReputation>
{
    public MercenaryReputationRepository(CrimesContext context) : base(context)
    {
    }
}