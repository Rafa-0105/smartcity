using Microsoft.EntityFrameworkCore;
using RestFul_api.Data;
using RestFul_api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestFul_api.Services
{
    public class DisasterService : IDisasterService
    {
        private readonly ApplicationDbContext _context;

        public DisasterService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<DisasterService> AddDisasterAsync(DisasterService disaster)
        {
            throw new NotImplementedException();
        }

        public Task<DisasterService> DeleteDisasterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DisasterService>> GetAllDisastersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DisasterService> GetDisasterByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DisasterService> UpdateDisasterAsync(DisasterService disaster)
        {
            throw new NotImplementedException();
        }
    }
}
