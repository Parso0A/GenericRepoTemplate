using GenericTestDomain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTestDomain.Model
{
    public class OrganizationDto
    {
        public OrganizationDto()
        {

        }
        public OrganizationDto(Organization org)
        {
            Id = org.Id;
            Name = org.Name;
            Address = org.Address;
            Field = org.Field;
            Personnel = org.Personnel;
        }
        public OrganizationDto(OrganizationViewModel org)
        {
            Id = org.Id;
            Name = org.Name;
            Address = org.Address;
            Field = org.Field;
            Personnel = org.Personnel;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Field { get; set; }
        public int Personnel { get; set; }
    }
}
