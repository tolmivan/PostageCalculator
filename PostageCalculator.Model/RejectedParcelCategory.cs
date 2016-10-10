using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Model
{
    public class RejectedParcelCategory : ParcelCategory
    {
        public override Category GetParcelCategory()
        {
            return Category.Rejected;
        }
        public override decimal? GetPostageCost(Parcel parcel)
        {
            return null;
        }
        public override string ToString()
        {
            return string.Format("{0}", GetParcelCategory());
        }
    }
}
