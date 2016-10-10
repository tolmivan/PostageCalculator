using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Model
{
    public class LargeParcelCategory : ParcelCategory
    {
        public override Category GetParcelCategory()
        {
            return Category.Large;
        }
        public override decimal? GetPostageCost(Parcel parcel)
        {
            return (decimal)(0.03 * parcel.Volume);
        }
    }
}
