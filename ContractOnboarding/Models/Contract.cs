namespace ContractOnboarding.Models;

public class Contract
{
    public string ContractType { get; set; } = string.Empty;
    public string Commodity { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public DateTime SignatureDate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public string GetFormattedPeriod()
    {
        return $"{StartDate:dd/MM/yyyy} – {EndDate:dd/MM/yyyy}";
    }
}