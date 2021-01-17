using GenericTestDomain.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GenericTestDomain.Model
{
    public class PersonViewModel 
    {
        public PersonViewModel()
        {

        }
        public PersonViewModel(PersonDto person)
        {
            Id = person.Id;
            Name = person.Name;
            FamilyName = person.FamilyName;
            Age = person.Age;
            Phone = person.Phone;
        }
        public Guid Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Family Name")]
        public string FamilyName { get; set; }
        [DisplayName("Age")]
        public int Age { get; set; }
        [DisplayName("Phone Number")]
        public string Phone { get; set; }
    }
}
