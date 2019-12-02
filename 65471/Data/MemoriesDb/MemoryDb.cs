using System.Collections.Generic;
using _65471.Data.Models;

namespace _65471.Data.MemoriesDb
{
    public class MemoryDb
    {
        public List<DataDto> DataDtoList { get; set; }

        public MemoryDb()
        {
            DataDtoList = new List<DataDto>();
        }
    }
}