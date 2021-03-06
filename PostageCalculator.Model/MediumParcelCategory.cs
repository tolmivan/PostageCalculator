﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Model
{
    public class MediumParcelCategory : ParcelCategory
    {
        public override Category GetParcelCategory()
        {
            return Category.Medium;
        }
        public override decimal? GetPostageCost(Parcel parcel)
        {
            return (decimal)(0.04 * parcel.Volume);
        }
    }
}
