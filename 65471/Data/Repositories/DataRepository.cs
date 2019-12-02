using System;
using System.Collections.Generic;
using System.Linq;
using _65471.Data.MemoriesDb;
using _65471.Data.Models;

namespace _65471.Data.Repositories
{
    public class DataRepository : IDataRepository
    {
        private readonly MemoryDb _memoryDb;

        public DataRepository(MemoryDb memoryDb)
        {
            _memoryDb = memoryDb;
        }

        public DataDto Get(Guid id)
            => _memoryDb.DataDtoList.FirstOrDefault(x => x.Id == id);

        public void Add(IEnumerable<DataDto> dataDtoList)
            => _memoryDb.DataDtoList.AddRange(dataDtoList);

        public void Clear()
            => _memoryDb.DataDtoList.Clear();
    }
}