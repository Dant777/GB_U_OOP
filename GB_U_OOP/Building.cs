using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_U_OOP
{
    public class Building
    {
        private static int _idCounter;
        private int _id;
        private double _maxHeight;
        private int _apartmentCount;
        private int _sectionCount;
        private int _maxLevelCount;
        private string _name;

        private readonly List<BuildingSection> _sections;

        public Building(string name):this(
            name,
            new List<BuildingSection>()
        {
            new BuildingSection()
        })
        {
           
        }

        public Building (string name, List<BuildingSection> sections)
        {
            _idCounter++;
            _id = _idCounter;
            _sections = sections;
            Name = name;
            CalculateMaxHeight();

        }


        public int Id
        {
            get => _id;
           
        }

        public double MaxHeight
        {
            get
            {
                CalculateMaxHeight();
                return _maxHeight;
            }
        }

        public int ApartmentCount
        {
            get
            {
                _apartmentCount = Sections.Sum(s => s.ApartmentCount);
                return _apartmentCount;
            }
        }

        public int SectionCount
        {
            get => _sectionCount = Sections.Count;
            
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int MaxLevelCount
        {
            get
            {
                _maxLevelCount = Sections.Max(s => s.LevelCount);
                return _maxLevelCount;
            }
        }

        public List<BuildingSection> Sections => _sections;

        public void AddSection(BuildingSection section)
        {
            Sections.Add(section);
            CalculateMaxHeight();

        }

        private List<BuildingLevel> GetSectionLevel(int sectionNumber)
        {
            List<BuildingLevel> levels = Sections.Find(s => s.SectionNumber == sectionNumber).Levels;
            return levels;
        }

        private void CalculateMaxHeight()
        {
            _maxHeight = Sections.Max(s => s.SectionHeight);
        }

    }
}