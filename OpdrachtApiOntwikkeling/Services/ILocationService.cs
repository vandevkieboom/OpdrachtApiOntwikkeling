﻿using OpdrachtApiOntwikkeling.Models;

namespace OpdrachtApiOntwikkeling.Services
{
    public interface ILocationService
    {
        public Task<List<Location>> GetLocations();
        public Task<Location?> GetLocationById(int id);
        public Task<List<Location>> SearchLocationsByName(string name);
        public Task AddLocation(Location location);
        public Task<Location?> UpdateLocation(int id, Location updatedLocation);
        public Task DeleteLocation(int id);
    }
}
