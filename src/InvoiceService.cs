namespace MyApp
{
    public class InvoiceService
    {
        public decimal CalculateTotal(decimal amount, bool hasDiscount)
        {
            return amount; // FOUT: korting wordt genegeerd
        }
    }
}
