using System;
using _65471.Data.Models;

namespace _65471.Data.Mappers
{
    public static class Mapper
    {
        public static DataDto MapDataToDto(Models.Data data)
        {
            var dataDto = new DataDto
            {
                Id = Guid.NewGuid(),
                Latitude = data.Latitude,
                Longitude = data.Longitude,
                Time = data.Time,
                Line = data.Line,
                Brigade = data.Brigade
            };
            
            return dataDto;
        }

        public static DataSingleDto MapDataToSingle(Models.Data data)
        {
            var dataSingleDto = new DataSingleDto
            {
                Latitude = data.Latitude,
                Longitude = data.Longitude,
                Time = data.Time,
                Line = data.Line,
                Brigade = data.Brigade
            };
            
            return dataSingleDto;
        }
    }
}