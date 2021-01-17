using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GenericTestDomain.Service
{
    public enum ObjectType
    {
        item=0,
        Person = 1,
        Car = 2,
        Organization = 3
    }
    public interface IObjectFactory
    {
        IObjectType Create(ObjectType type);
    }
}
