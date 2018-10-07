﻿namespace AnimalMatcher.Services.Models.Pet
{
    public class PetServiceModel
    {
        public int Id { get; set; }

        public int Age { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string OwnerId { get; set; }

        public string OwnerUsername { get; set; }
    }
}
