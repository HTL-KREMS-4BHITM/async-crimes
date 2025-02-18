using Model.Entities;

namespace Domain;

public interface ICompartmentRepository : IRepositoryAsync<Compartment>
{
    Task<Compartment?> LoadCompartmentGraph(int id);
}