using RestFul_api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestFul_api.Data;

namespace RestFul_api.Services
{
    public interface IDisasterService
    {
        Task<IEnumerable<DisasterService>> GetAllDisastersAsync();
        Task<DisasterService> GetDisasterByIdAsync(int id);
        Task<DisasterService> AddDisasterAsync(DisasterService disaster);
        Task<DisasterService> UpdateDisasterAsync(DisasterService disaster);
        Task<DisasterService> DeleteDisasterAsync(int id);
    }
}
