using GenericTestDomain.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GenericTestDomain.Model
{
    public class CarViewModel
    {
        public CarViewModel()
        {

        }
        public CarViewModel(CarDto car)
        {
            Id = car.Id;
            Brand = car.Brand;
            Name = car.Name;
            Model = car.Model;
            TopSpeed = car.TopSpeed;
        }
        public Guid Id { get; set; }
        [DisplayName("Brand")]
        public string Brand { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Model")]
        public string Model { get; set; }
        [DisplayName("Top Speed")]
        public int TopSpeed { get; set; }
    }
}
