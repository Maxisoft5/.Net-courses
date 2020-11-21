using System;
using System.Collections.Generic;
using System.Text;

namespace StructTask.Interfaces
{
    interface ICordinates
    {
        /// <summary>
        /// Coordinates array which will be calculated width and height
        /// </summary>
        public double[] X { get; set; }

        /// <summary>
        /// Coordinates array which will be calculated width and height
        /// </summary>
        public double[] Y { get; set; }
    }
}
