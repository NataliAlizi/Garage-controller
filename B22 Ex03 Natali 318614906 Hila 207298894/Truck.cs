﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B22_Ex03_Natali_318614906_Hila_207298894
{
    public class Truck : FuelType
    {
        private bool m_DriveRefrigeratedContents;
        private float m_CargoCapacity;
        private enum eTruckData
        {
            NumberOfWheels=16, MaxAirPressuer=24,MaxAmountOfFuelInCm=120000, FuelTypeTruck=FuelType.eFuelType.Soler
        }

        public Truck(bool i_DriveRefrigeratedContents, float i_CargoCapacity, string i_FuelType, float i_CurrAmountOfFuel, float i_MaxAmountOfFuel, string i_ModelName, string i_LicenseNumber, float i_RemainEnergyPercents, List<Wheel> i_ListOfWheel) :
            base(i_FuelType, i_CurrAmountOfFuel, i_MaxAmountOfFuel, i_ModelName, i_LicenseNumber, i_RemainEnergyPercents, i_ListOfWheel)
        {
            m_DriveRefrigeratedContents = i_DriveRefrigeratedContents;
            m_CargoCapacity = i_CargoCapacity;
        }

        public bool DriveRefrigeratedContents
        {
            get { return m_DriveRefrigeratedContents; }
            set { m_DriveRefrigeratedContents = value; }
        }

        public float CargoCapacity
        {
            get { return m_CargoCapacity; }
            set { m_CargoCapacity = value; }
        }
    }
}
