using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_U_OOP.BuilderPattern.Interfaces;

namespace GB_U_OOP.BuilderPattern
{
    public class BuildingBuilder:IBuilder
    {
        private Building _building;
        public BuildingBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _building = new Building("");
        }
        public void BuildSection()
        {
            _building.AddSection(new BuildingSection());
        }

        public void BuildLevel(int sectionIndex, BuildingLevel level)
        {
            if (sectionIndex > _building.Sections.Count - 1 || sectionIndex < 0)
            {
                return;
            }
            _building.Sections[sectionIndex].AddLevel(level);
        }

        public Building GetBuilding()
        {
            Building result = _building;
           
            return result;
        }
    }
}
