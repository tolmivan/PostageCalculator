using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Model
{
    public class SmallParcelCategory : ParcelCategoryBase
    {
        public override Category ParcelCategory
        {
            get
            {
                return Category.Small;
            }
        }
        public override decimal? GetPostageCost(Parcel parcel)
        {
            return (decimal)(0.05 * parcel.Volume);
        }
    }
}
