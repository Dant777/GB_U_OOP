using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_U_OOP
{
    public class BuildingSection
    {
        private readonly List<BuildingLevel> _levels;
        private int _sectionNumber;
        private int _levelCount;
        private double _sectionHeight;
        private int _apartmentCount;

        public BuildingSection()
        {
            _levels = new List<BuildingLevel>()
            {
                new BuildingLevel()
            };
        }

        public BuildingSection(List<BuildingLevel> levels)
        {
            _levels = levels;
            _levelCount = GetLevelCount();
        }

        public int SectionNumber
        {
            get => _sectionNumber;
            set => _sectionNumber = value;
        }

        public int LevelCount
        {
            get
            {
                _levelCount = GetLevelCount();
                return _levelCount;
            }

        }

        public List<BuildingLevel> Levels => _levels;

        public double SectionHeight
        {
            get
            {
                _sectionHeight = Levels.Sum(l => l.LevelHeight);
                return _sectionHeight;
            }
        }

        public int ApartmentCount
        {
            get
            {
                _apartmentCount = _levels.Sum(l => l.ApartmentCount);
                return _apartmentCount;
            }
        }

        public void AddLevel(BuildingLevel level)
        {
            Levels.Add(level);
            _levelCount = GetLevelCount();
        }

        private int GetLevelCount()
        {
            return Levels.Count;
        }
    }
}
