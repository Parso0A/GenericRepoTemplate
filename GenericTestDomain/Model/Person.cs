using GenericTestDomain.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GenericTestDomain.Model
{
    public class Person : EntityType, IObjectType
    {
        public Person()
        {

        }
        public Person(PersonDto person)
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
        [MaxLength(50)]
        public string Phone { get; set; }
    }
}
