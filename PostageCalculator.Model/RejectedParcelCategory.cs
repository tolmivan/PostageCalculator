using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Model
{
    public class RejectedParcelCategory : ParcelCategoryBase
    {
        public override Category ParcelCategory
        {
            get
            {
                return Category.Rejected;
            }
        }
        public override decimal? GetPostageCost(Parcel parcel)
        {
            return null;
        }
        public override string ToString()
        {
            return string.Format("{0}", ParcelCategory);
        }
    }
}
