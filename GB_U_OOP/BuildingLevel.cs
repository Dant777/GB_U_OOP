using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_U_OOP
{
    public class BuildingLevel
    {
        private double _height;
        private string _name;
        private int _apartmentCount;

        public BuildingLevel():this("1", 3.3, 7)
        {
            
        }
        public BuildingLevel(string name) : this(name, 3.3, 7)
        {
            
        }

        public BuildingLevel(string name, double height) : this(name, height, 7)
        {

        }

        public BuildingLevel(string name ,double height, int apartmentCount)
        {
            _name = name;
            _height = height;
            _apartmentCount = apartmentCount;
        }

        public double LevelHeight
        {
            get => _height;
            set => _height = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int ApartmentCount
        {
            get => _apartmentCount;
            set => _apartmentCount = value;
        }
    }
}
