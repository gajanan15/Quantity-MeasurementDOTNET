// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement
{
    using System;

    /// <summary>
    /// Main Class For Feet Data.
    /// </summary>
    public class QuantityMeasurement
    {
        /// <summary>
        /// Parameter Constructor to Set Value.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public double ReturnUnits(UnitTypeEnum.UnitType type, double unit)
        {
            return unit * new UnitTypeEnum().Conversion(type);
        }

        /// <summary>
        /// Addition Of Two Units.
        /// </summary>
        /// <param name="uintOne"></param>
        /// <param name="unitTwo"></param>
        /// <returns></returns>
        public double Add(double uintOne, double unitTwo)
        {
            return uintOne + unitTwo;
        }

        /// <summary>
        /// Overridding Equals Method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            if (obj is QuantityMeasurement)
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
