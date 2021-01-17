using GenericTestDomain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTestDomain.Model
{
    public class Car : EntityType, IObjectType
    {
        public Car()
        {

        }
        public Car(CarDto car)
        {
            Id = car.Id;
            Brand = car.Brand;
            Name = car.Name;
            Model = car.Model;
            TopSpeed = car.TopSpeed;
        }
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int TopSpeed { get; set; }
    }
}
