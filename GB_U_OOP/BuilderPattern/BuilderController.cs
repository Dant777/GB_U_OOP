using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_U_OOP.BuilderPattern.Interfaces;

namespace GB_U_OOP.BuilderPattern
{
    public class BuilderController
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set => _builder = value;
        }

        public void CreateTypeA()
        {
            _builder.BuildSection();
            _builder.BuildLevel(0, new BuildingLevel());
            _builder.BuildLevel(1, new BuildingLevel());
        }

        public void CreateTypeB()
        {
            _builder.BuildSection();
            _builder.BuildSection();
            _builder.BuildLevel(0, new BuildingLevel());
            _builder.BuildLevel(0, new BuildingLevel());
            _builder.BuildLevel(0, new BuildingLevel());
            _builder.BuildLevel(0, new BuildingLevel());
            _builder.BuildLevel(1, new BuildingLevel());
            _builder.BuildLevel(1, new BuildingLevel());
            _builder.BuildLevel(1, new BuildingLevel());
            _builder.BuildLevel(1, new BuildingLevel());
            _builder.BuildLevel(1, new BuildingLevel());
            _builder.BuildLevel(2, new BuildingLevel());
            _builder.BuildLevel(2, new BuildingLevel());
            _builder.BuildLevel(2, new BuildingLevel());
            _builder.BuildLevel(2, new BuildingLevel());
        }
    }
}