using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_U_OOP.BuilderPattern.Interfaces
{
    public interface IBuilder
    {
        void BuildSection();

        void BuildLevel(int sectionIndex, BuildingLevel level);
    }
}