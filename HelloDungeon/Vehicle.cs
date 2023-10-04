using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Vehicle
    {
        private string _name;
        private string _year;
        private string _brand;
        private string _color;
        private float _health;
        private float _speed;
        private float _topSpeed;
        private float _acceleration;
        private float _wheelCount;
        private float _seatCount;
        private bool _seatWarmerFeature;
        
        //this is the default constructor

        //this is making the overloading constructor
        public Vehicle(string name, string year, string brand, string color, float health, float speed, float topSpeed, float acceleration, float wheelCount, float seatCount, bool seatWarmerFeature)
        {
            _name = name;
            _year = year;
            _brand = brand;
            _color = color;
            _health = health;
            _speed = speed;
            _topSpeed = topSpeed;
            _acceleration = acceleration;
            _wheelCount = wheelCount;
            _seatCount = seatCount;
            _seatWarmerFeature = seatWarmerFeature;
        }

        public void Accelerate()
        {
            //increase _speed until it reaches _topSpeed
        }
        
        public void Brake()
        {
            //rapidly decrease _speed until it reaches 0
        }
    }
}
