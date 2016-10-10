using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Model
{
    public class Parcel
    {
        /// <summary>
        /// weight of parcel, kg
        /// </summary>
        public int Weight { get; private set; }
        /// <summary>
        /// height of parcel, cm
        /// </summary>
        public int Height { get; private set; }
        /// <summary>
        /// width of parcel, cm
        /// </summary>
        public int Width { get; private set; }
        /// <summary>
        /// depth of parcel, cm
        /// </summary>
        public int Depth { get; private set; }
        /// <summary>
        /// volume of parcel, cubic cm
        /// </summary>
        public int Volume
        {
            get
            {
                return Height * Width * Depth;
            }
        }
        /// <summary>
        /// category of parcel
        /// </summary>
        public string GetParcelCategory()
        {
            return _parcelCategory.ToString();
        }
        /// <summary>
        /// postage cost, $
        /// </summary>
        public string PrintPostageCost()
        {
            return _parcelCategory.PrintPostageCost(this);
        }

        private ParcelCategory _parcelCategory;

        public Parcel(int weight, int height, int width, int depth)
        {
            if (weight <= 0 || height <= 0 || width <= 0 || depth <= 0)
                throw new ArgumentException("Parcel dimensions must be positive values");

            Weight = weight;
            Height = height;
            Width = width;
            Depth = depth;
            
            SetCategory();
        }

        private void SetCategory(){
            if (this.Weight > 50)
                _parcelCategory = new RejectedParcelCategory();
            else if (this.Weight > 10)
                _parcelCategory = new HeavyParcelCategory();
            else if (this.Volume < 1500)
                _parcelCategory = new SmallParcelCategory();
            else if (this.Volume < 2500)
                _parcelCategory = new MediumParcelCategory();
            else
                _parcelCategory = new LargeParcelCategory();
        }

    }
}
