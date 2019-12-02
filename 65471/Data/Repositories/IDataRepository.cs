using System;
using System.Collections.Generic;
using _65471.Data.Models;

namespace _65471.Data.Repositories
{
    public interface IDataRepository
    {
        DataDto Get(Guid id);
        void Add(IEnumerable<DataDto> dataDtoList);
        void Clear();
    }
}