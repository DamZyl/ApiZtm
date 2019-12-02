using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using _65471.Data.Models;

namespace _65471.Data.Services
{
    public interface IDataService
    {
        Task<IEnumerable<DataDto>> GetAllAsync();
        Task<DataSingleDto> GetAsync(Guid id);
    }
}