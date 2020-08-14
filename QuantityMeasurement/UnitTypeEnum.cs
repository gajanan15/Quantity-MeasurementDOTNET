// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Craete Class.
    /// </summary>
    public class UnitTypeEnum
    {
        /// <summary>
        /// Craete LengthType Enum.
        /// </summary>
        public enum UnitType
        {
            FEET,
            INCHES,
            YARD,
            CENTIMETER,
            GALLON,
            LITRE,
            MILLILITRE
        }

        /// <summary>
        /// Unit Conversion Method.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public double Conversion(UnitType type)
        {
            if (type.Equals(UnitType.FEET))
            {
                return 1.0 * 12.0;
            }

            if (type.Equals(UnitType.YARD))
            {
                return 1 * 36.0;
            }

            if (type.Equals(UnitType.CENTIMETER))
            {
                return 1 / 2.5;
            }

            if (type.Equals(UnitType.GALLON))
            {
                return 1 * 3785;
            }

            if (type.Equals(UnitType.LITRE))
            {
                return 1 * 1000;
            }

            if (type.Equals(UnitType.MILLILITRE))
            {
                return 1.0;
            }
            else
            {
                return 1.0;
            }
        }
    }
}
