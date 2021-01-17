using GenericTestDomain.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GenericTestDomain.Model
{
    public class OrganizationViewModel
    {
        public OrganizationViewModel()
        {

        }
        public OrganizationViewModel(OrganizationDto org)
        {
            Id = org.Id;
            Name = org.Name;
            Address = org.Address;
            Field = org.Field;
            Personnel = org.Personnel;
        }
        public Guid Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("Field")]
        public string Field { get; set; }
        [DisplayName("Personnel Count")]
        public int Personnel { get; set; }
    }
}
