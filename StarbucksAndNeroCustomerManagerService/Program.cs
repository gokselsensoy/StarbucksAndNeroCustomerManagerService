// See https://aka.ms/new-console-template for more information


using StarbucksAndNeroCustomerManagerService;
using StarbucksAndNeroCustomerManagerService.Abstract;
using StarbucksAndNeroCustomerManagerService.Adapters;
using StarbucksAndNeroCustomerManagerService.Concrete;

BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer { DateOfBirth = new DateTime(1998, 11, 1), FirstName = "Göksel", LastName = "Şensoy", NationalityId = "47104708180" });
customerManager.Save(new Customer { DateOfBirth = new DateTime(1999, 2, 4), FirstName = "Feride Yağmur", LastName = "Uz", NationalityId = "22981527130" });
BaseCustomerManager customerManager2 = new NeroCustomerManager();
customerManager.Save(new Customer { DateOfBirth = new DateTime(1998, 2, 4), FirstName = "Feride Yağmur", LastName = "Uz", NationalityId = "22981527130" });
Console.ReadLine();