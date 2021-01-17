using GenericTestDomain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTestDomain.Model
{
    public class PersonDto
    {
        public PersonDto()
        {

        }
        public PersonDto(Person person)
        {
            Id = person.Id;
            Name = person.Name;
            FamilyName = person.FamilyName;
            Age = person.Age;
            Phone = person.Phone;
        }
        public PersonDto(PersonViewModel person)
        {
            Id = person.Id;
            Name = person.Name;
            FamilyName = person.FamilyName;
            Age = person.Age;
            Phone = person.Phone;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }
}
