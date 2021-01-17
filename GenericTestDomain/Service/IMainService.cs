using GenericTestDomain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericTestDomain.Service
{
    public interface IMainService
    {
        Task<bool> AddPerson(Person entity);
        Task<bool> AddOrg(Organization entity);
        Task<bool> AddCar(Car entity);
        Task<List<Person>> GetAllPeople();
        Task<List<Car>> GetAllCars();
        Task<List<Organization>> GetAllOrgs();
        Task<bool> UpdateOrg(Organization entity);
        Task<bool> UpdatePerson(Person entity);
        Task<bool> UpdateCar(Car entity);
        Task<bool> DeleteCar(Car entity);
        Task<bool> DeleteOrg(Organization entity);
        Task<bool> DeletePerson(Person entity);
    }
}
