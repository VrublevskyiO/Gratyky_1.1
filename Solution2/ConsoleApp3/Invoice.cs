namespace ConsoleApp7;

public class Invoice
{
    public int Account { get; init; }
    public string Customer { get; }
    public string Provider { get; }
    private string Article { get; set; }
    private int Quantity { get; set; } = 4;

    public Invoice(int account, string customer, string provider)
    {
        Account = account;
        Customer = customer;
        Provider = provider;
    }

    public double ShowSumWithTax()
    {
        return Quantity * Account * 1.2;
    }
   
    public double ShowSumWithOutTax()
    {
        return Quantity * Account;
    }
    
}