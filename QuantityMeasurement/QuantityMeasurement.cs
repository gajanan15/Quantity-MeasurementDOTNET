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
        /// <param name="feet"></param>
        /// <returns></returns>
        public double ReturnFeet(double feet)
        {
            return feet;
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
