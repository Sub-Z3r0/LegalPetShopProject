﻿using PetApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetAppCore.ApplicationServices.Services
{
    public interface IOwnerServices
    {
        Owner GetOwnerInstance();

        List<Owner> GetOwners();

        Owner AddOwner(Owner owner);

        void DeleteOwner(int id);

        List<Owner> FindOwnerName();

        Owner FindOwnerById(int id);

        Owner FindOwnerByIdIncludePets(int id);

        Owner UpdateOwner(Owner ownerUpdate);
    }
}
