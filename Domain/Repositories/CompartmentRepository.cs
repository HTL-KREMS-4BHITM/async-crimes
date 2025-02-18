using Model;
using Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories;

public class CompartmentRepository : ARepositoryAsync<Compartment>, ICompartmentRepository
{
    private readonly CrimesContext _context;
    public CompartmentRepository(CrimesContext context) : base(context)
    {
        _context = context;
    }
    
    public async Task<Compartment?> LoadCompartmentGraph(int id)
    {
        return await _context.Compartments
            .FirstOrDefaultAsync(c => c.CompartmentId == id);
    }
}