﻿using Microsoft.Extensions.DependencyInjection;
using PetApp.Infastructure.Static.Data.Repositories;
using PetAppCore.ApplicationServices;
using PetAppCore.ApplicationServices.Services;
using PetAppCore.DomainService;
using PetAppCore.Services;
using System;

namespace LegalPetShop
{
    public class PetProgramMain
    {
        static void Main(string[] args)
        {
            FakeDB.InitData();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepositories, PetRepositories>();
            serviceCollection.AddScoped<IPetService, PetServices>();
            serviceCollection.AddScoped<IOwnerRepositories, OwnerRepositories>();
            serviceCollection.AddScoped<IOwnerServices, OwnerServices>();

            serviceCollection.AddScoped<IPrinter, Printer>();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.StartUI();
        }
    }
}
