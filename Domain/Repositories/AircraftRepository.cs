using Microsoft.EntityFrameworkCore;
using Model;
using Model.Entities;

namespace Domain.Repositories;

public class AircraftRepository : ARepositoryAsync<Aircraft>, IAircraftRepository
{
    private readonly CrimesContext _context;
    public AircraftRepository(CrimesContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Aircraft?> LoadAircraftGraph(int id)
    {
        return await _context.Aircrafts
            .FirstOrDefaultAsync(a => a.AircraftId == id);
    }
}