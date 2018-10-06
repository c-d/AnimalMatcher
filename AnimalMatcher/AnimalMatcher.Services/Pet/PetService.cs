﻿namespace AnimalMatcher.Services.Pet
{
    using AnimalMatcher.Data.Repository.Interfaces;
    using AnimalMatcher.Data.Models;
    using System.Collections.Generic;
    using AnimalMatcher.Specifications;
    using AutoMapper;
    using System.Linq;
    using AnimalMatcher.Services.Pet.Interfaces;
    using AnimalMatcher.Services.Models.Pet;

    public class PetService : IPetService
    {
        private readonly IGenericRepository<Pet> petRepository;
        private readonly IMapper mapper;

        public PetService(IGenericRepository<Pet> petRepository, IMapper mapper)
        {
            this.petRepository = petRepository;
            this.mapper = mapper;
        }

        public IEnumerable<PetServiceModel> GetOwnersAnimals(string ownerId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PetServiceModel> GetOwnersPets(string ownerId)
        {
            var getAnimalByOwnerSpecification = new Specification<Pet>(pet => pet.OwnerId.Equals(ownerId));
            getAnimalByOwnerSpecification.AddInclude(pet => pet.Owner);

            var petsForOwner = this.petRepository
                .List(getAnimalByOwnerSpecification)
                .Select(petDataModel => this.mapper.Map<PetServiceModel>(petDataModel))
                .ToList();

            return petsForOwner;
        }
    }
}