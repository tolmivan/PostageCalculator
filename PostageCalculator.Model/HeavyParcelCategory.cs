using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Model
{
    public class HeavyParcelCategory : ParcelCategoryBase
    {
        public override Category ParcelCategory
        {
            get
            {
                return Category.Heavy;
            }
        }
        public override decimal? GetPostageCost(Parcel parcel)
        {
            return (decimal)(15 * parcel.Weight);
        }
    }
}
