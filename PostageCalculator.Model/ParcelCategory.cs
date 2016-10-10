using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Model
{
    public enum Category
    {
        Rejected = 1,
        Heavy = 2,
        Small = 3,
        Medium = 4,
        Large = 5
    }

    public abstract class ParcelCategory
    {
        public abstract Category GetParcelCategory();
        public abstract decimal? GetPostageCost(Parcel parcel);
        public virtual string PrintPostageCost(Parcel parcel)
        {
            if (GetPostageCost(parcel).HasValue)
            {
                return string.Format("{0:c0}", decimal.Ceiling(GetPostageCost(parcel).Value));
            }
            else
            {
                return "N/A";
            }
        }
        public override string ToString()
        {
            return string.Format("{0} Parcel", GetParcelCategory());
        }


    }
}
