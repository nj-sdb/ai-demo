using Xunit;
using MyApp;

public class TestInvoiceService
{
    [Fact]
    public void Should_Calculate_Total_With_Discount()
    {
        var service = new InvoiceService();
        var result = service.CalculateTotal(100, true);
        Assert.Equal(90, result); // Verwacht 10% korting
    }
}
