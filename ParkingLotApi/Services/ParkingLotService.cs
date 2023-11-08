﻿using ParkingLotApi.Dtos;
using ParkingLotApi.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParkingLotApi.Services
{
    public class ParkingLotService
    {
        public async Task<ParkingLotDto> AddAsync(ParkingLotDto data)
        {
            if (data.Capacity < 10)
            {
                throw new InvalidCapacityException();
            }

            return null;
        }
    }
}
