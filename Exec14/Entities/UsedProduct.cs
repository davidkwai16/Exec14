using System;
using System.Globalization;

namespace Exec14.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDay { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDay)
            : base(name, price)
        {
            ManufactureDay = manufactureDay;
        }

        public override string PriceTag()
        {
            return Name + " (Used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
               + " (Manufacture date " + ManufactureDay.ToString("dd/MM/yyyy") + ")";
        }
    }
}
