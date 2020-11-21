using System;
using System.Collections.Generic;
using System.Text;

namespace StructTask.Interfaces
{
    interface ISize
    {
        /// <summary>
        /// Width of Reactangle
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Height of Reactangle
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Calculates perimeter of reactangle
        /// </summary>
        /// <returns>Reactangle's perimeter</returns>
        double Perimeter();

    }
}
