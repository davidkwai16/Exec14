using System.Globalization;

namespace Exec14.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price,double customsFee)
            : base(name,price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return base.Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
               + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
