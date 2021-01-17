using GenericTestDataAccess;
using GenericTestDomain.Model;
using GenericTestDomain.Repository;
using GenericTestDomain.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericTestService
{
    public class MainService : IMainService
    {
        private readonly IGenericTestRepository<Person> _personRepo;
        private readonly IGenericTestRepository<Car> _carRepo;
        private readonly IGenericTestRepository<Organization> _orgRepo;
        public MainService(IGenericTestRepository<Person> personRepo, IGenericTestRepository<Car> carRepo, IGenericTestRepository<Organization> orgRepo)
        {
            _carRepo = carRepo;
            _orgRepo = orgRepo;
            _personRepo = personRepo;
        }
        public async Task<bool> AddCar(Car entity)
        {
            await _carRepo.Add(entity);
            return await _carRepo.SaveAsync();
        }
        public async Task<bool> UpdateCar(Car entity)
        {
            await _carRepo.Update(entity);
            return await _carRepo.SaveAsync();
        }
        public async Task<bool> DeleteCar(Car entity)
        {
            await _carRepo.Delete(entity);
            return await _carRepo.SaveAsync();
        }
        public async Task<bool> AddOrg(Organization entity)
        {
            await _orgRepo.Add(entity);
            return await _orgRepo.SaveAsync();
        }
        public async Task<bool> UpdateOrg(Organization entity)
        {
            await _orgRepo.Update(entity);
            return await _orgRepo.SaveAsync();
        }
        public async Task<bool> DeleteOrg(Organization entity)
        {
            await _orgRepo.Delete(entity);
            return await _orgRepo.SaveAsync();
        }
        public async Task<bool> AddPerson(Person entity)
        {
            await _personRepo.Add(entity);
            return await _personRepo.SaveAsync();
        }
        public async Task<bool> UpdatePerson(Person entity)
        {
            await _personRepo.Update(entity);
            return await _personRepo.SaveAsync();
        }
        public async Task<bool> DeletePerson(Person entity)
        {
            await _personRepo.Delete(entity);
            return await _personRepo.SaveAsync();
        }
        public async Task<List<Car>> GetAllCars()
        {
            return (await _carRepo.GetAll());
        }

        public async Task<List<Organization>> GetAllOrgs()
        {
            return await _orgRepo.GetAll();
        }

        public async Task<List<Person>> GetAllPeople()
        {
            return await _personRepo.GetAll();
        }
    }
}
