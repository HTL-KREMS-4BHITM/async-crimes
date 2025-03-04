using Model;
using Model.Entities;

namespace Domain.Repositories;

public class CrimeSyndicateRepository : ARepositoryAsync<CrimeSyndicate>
{
    public CrimeSyndicateRepository(CrimesContext context) : base(context)
    {
    }
}