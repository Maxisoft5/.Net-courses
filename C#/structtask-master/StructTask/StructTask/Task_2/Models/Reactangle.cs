using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;
using StructTask.Interfaces;

namespace StructTask.Models
{
    /// <summary>
    /// Struct model
    /// </summary>
    public struct Reactangle : ICordinates, ISize
    {
        private double _width;
        private double _height;
        private double[] _x;
        private double[] _y;

        #region Properties
        /// <summary>
        /// Width of the rectangle
        /// </summary>
        public double Width
        {
            get { return this._width; }
            set
            {
                if (value > 0)
                {
                    this._width = value;
                }
                else
                {
                    this._width = default;
                }
            }
        }

        /// <summary>
        /// Height of the rectangle
        /// </summary>
        public double Height
        {
            get { return this._height; }
            set
            {
                if (value > 0)
                {
                    this._height = value;
                }
                else
                {
                    this._x = default;
                }
            }
        }

        /// <summary>
        /// X coordinates of the rectangle
        /// </summary>
        public double[] X
        {
            get { return this._x; }
            set
            {
                if (value.Length > 0 && value.Length <= 4)
                {
                    this._x = value;
                }
                else
                {
                    this._x = default;
                }
            }
        }

        /// <summary>
        /// Y coordinates of the rectangle
        /// </summary>
        public double[] Y
        {
            get { return this._y; }
            set
            {
                if (value.Length > 0 && value.Length <= 4)
                {
                    this._x = value;
                }
                else
                {
                    this._x = default;
                }
            }
        }
        #endregion

        #region Constructors 
        public Reactangle(double width, double height)
        {
            this._width = width;
            this._height = height;
            _x = new double[] { 0, 0, width, width };
            _y = new double[] { 0, height, height, 0 };

        }
        public Reactangle(double[] x, double[] y)
        {
            if (x.Length <= 0 || y.Length <= 0 || x.Length > 4 || y.Length > 4)
            {
                throw new ArgumentException("Wrong number of coordinates");
            }
            _x = x;
            _y = y;
            (double x, double y)[] coordinates = new (double x, double y)[4];
            for (int i = 0; i < _x.Length; i++)
            {
                var coordinate = (x[i], y[i]);
                coordinates[i] = coordinate;
            }
            this._height = coordinates[1].y - coordinates[0].y;
            this._width = coordinates[2].x - coordinates[1].x;
        }
        #endregion
        public double Perimeter()
        {
            return (Width + Height) * 2;
        }
    }
}
