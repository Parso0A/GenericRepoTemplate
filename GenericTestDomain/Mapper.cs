using GenericTestDomain.Model;
using System.Collections.Generic;

namespace GenericTestDomain
{
    public static class Mapper
    {
        public static CarDto MapCarToDto(this Car car)
        {
            return new CarDto(car);
        }
        public static CarViewModel MapDtoToVm(this CarDto car)
        {
            return new CarViewModel(car);
        }
        public static Car MapDtoToCar(this CarDto car)
        {
            return new Car(car);
        }
        public static List<CarDto> MapCarListToDto(this List<Car> cars)
        {
            var toReturn = new List<CarDto>();
            foreach (var car in cars)
                toReturn.Add(car.MapCarToDto());
            return toReturn;
        }
        public static List<CarViewModel> MapCarDtoListToVm(this List<CarDto> cars)
        {
            var toReturn = new List<CarViewModel>();
            foreach (var car in cars)
                toReturn.Add(car.MapDtoToVm());
            return toReturn;
        }
        public static OrganizationDto MapOrgToDto(this Organization org)
        {
            return new OrganizationDto(org);
        }
        public static List<OrganizationDto> MapOrgListToDto(this List<Organization> orgs)
        {
            var toReturn = new List<OrganizationDto>();
            foreach (var org in orgs)
                toReturn.Add(org.MapOrgToDto());
            return toReturn;
        }
        public static OrganizationViewModel MapOrgDtoToVm(this OrganizationDto org)
        {
            return new OrganizationViewModel(org);
        }
        public static List<OrganizationViewModel> MapOrgDtoListToVm(this List<OrganizationDto> orgs)
        {
            var toReturn = new List<OrganizationViewModel>();
            foreach (var org in orgs)
                toReturn.Add(org.MapOrgDtoToVm());
            return toReturn;
        }
        public static OrganizationDto MapOrgVmToDto(this OrganizationViewModel org)
        {
            return new OrganizationDto(org);
        }
        public static Organization MapOrgDtoToOrg(this OrganizationDto org)
        {
            return new Organization(org);
        }
        public static PersonDto MapPersonToDto(this Person person)
        {
            return new PersonDto(person);
        }
        public static List<PersonDto> MapPersonListToDto(this List<Person> people)
        {
            var toReturn = new List<PersonDto>();
            foreach (var person in people)
                toReturn.Add(person.MapPersonToDto());
            return toReturn;
        }
        public static PersonViewModel MapPersonDtoToVm(this PersonDto person)
        {
            return new PersonViewModel(person);
        }
        public static List<PersonViewModel> MapDtoListToVm(this List<PersonDto> people)
        {
            var toReturn = new List<PersonViewModel>();
            foreach (var person in people)
                toReturn.Add(person.MapPersonDtoToVm());
            return toReturn;
        }
        public static PersonDto MapPersonVmToDto(this PersonViewModel person)
        {
            return new PersonDto(person);
        }
        public static Person MapDtoToPerson(this PersonDto person)
        {
            return new Person(person);
        }
    }
}