using System;
using System.Collections.Generic;
using System.Linq;
using GB_U_OOP;
using GB_U_OOP.BuilderPattern;


namespace ConsoleBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderController controller = new BuilderController();
            BuildingBuilder builder = new BuildingBuilder();
            BuildingBuilder builder_2 = new BuildingBuilder();
            controller.Builder = builder;
            controller.CreateTypeA();
            PrintInfo(builder.GetBuilding());

            Console.WriteLine("==================");
            controller.Builder = builder_2;
            controller.CreateTypeB();
            PrintInfo(builder_2.GetBuilding());
            Console.ReadKey();
        }

        private static void PrintInfo(Building building)
        {
            Console.WriteLine($"Building: {building.Name}; ID: {building.Id};" );
            Console.WriteLine($"\t-Section count: {building.SectionCount};" );
            Console.WriteLine($"\t-Max height: {building.MaxHeight};" );
            Console.WriteLine($"\t-Max level count: {building.MaxLevelCount};" );
            Console.WriteLine($"\t-Apartment Count: {building.ApartmentCount};" );
        }
       
    }

   
}
