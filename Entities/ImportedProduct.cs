using System.Globalization;

namespace Exercicio_fixação_Herança_e_Polimorfismo.Entities
{
    public class ImportedProduct : Product
    {
        
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }
        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            CustomFee = customFee;

        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            return Name
            + " $ "
            + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
            + " (CustomFee: $ "
            + CustomFee.ToString("F2", CultureInfo.InvariantCulture)
            + ")";
            
        }
    }
}