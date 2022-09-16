namespace ConsoleApp5;

public class Converter
{
    private double usd;
    private double eur;
    private double rub;
    public double Usd { get; set; }
    public double Eur { get; set; }
    public double Rub { get; set; }

    public Converter(double usd, double eur, double rub)
    {
        Eur = eur;
        Rub = rub;
        Usd = usd;
    }
    
    public double ConvertingUahToEur(double value)
    {
        return value / Eur;
    }
    
    public double ConvertingUahToRub(double value)
    {
        return value / Rub;
    }
    
    public double ConvertingUahToUsd(double value)
    {
        return value / Usd;
    }
    
    public double ConvertingEurToUah(double value)
    {
        return value * Eur;
    }
    
    public double ConvertingRubToUah(double value)
    {
        return value * Rub;
    }
    
    public double ConvertingUsdToUah(double value)
    {
        return value * Usd;
    }
}