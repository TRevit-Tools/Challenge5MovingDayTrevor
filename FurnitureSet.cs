using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5MovingDayTrevor
{
    public class FurnitureSet
    {
        public string FurnSetName { get; set; }
        public string RoomType { get; set; }
        public string IncludedFurniture { get; set; }


        public FurnitureSet(string name, string address, string numFloors)
        {
            FurnSetName = name;
            RoomType = address;
            IncludedFurniture = numFloors;
            
        }

        /*public double GetBuildingArea()
        {
            return Area * NumFloors;
        }*/
    }

    public class FurnitureType
    {
        public string FurnTypeName { get; set; }
        public string FurnFamilyName { get; set; }
        public string RevitFamilyType { get; set; }

        public FurnitureType(string furnType, string famName, string famTypeName)
        {
            FurnTypeName = furnType;
            FurnFamilyName = famName;
            RevitFamilyType = famTypeName;

        }
    }


}