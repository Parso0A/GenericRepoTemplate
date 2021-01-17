using GenericTestDomain.Model;
using GenericTestDomain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTestService
{
    public class ObjectFactory : IObjectFactory
    {
        public IObjectType Create(ObjectType type)
        {
            switch (type)
            {
                case ObjectType.Car:
                    return new Car();
                case ObjectType.Organization:
                    return new Organization();
                case ObjectType.Person:
                    return new Person();
                default:
                    break;
            }
            return null;
        }
    }
}
