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
    public class LengthTypeEnum
    {
        /// <summary>
        /// Craete LengthType Enum.
        /// </summary>
        public enum LengthType
        {
            FEET,
            INCHES,
            YARD
        }

        /// <summary>
        /// Unit Conversion Method.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public double Conversion(LengthType type)
        {
            if (type.Equals(LengthType.FEET))
            {
                return 1.0 * 12.0;
            }

            if (type.Equals(LengthType.YARD))
            {
                return 1 * 36.0;
            }
            else
            {
                return 1.0;
            }
        }
    }
}
