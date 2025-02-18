using Model.Entities;

namespace Domain;

public interface IAircraftRepository : IRepositoryAsync<Aircraft>
{
    Task<Aircraft?> LoadAircraftGraph(int id);
}