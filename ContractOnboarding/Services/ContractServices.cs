using ContractOnboarding.Models;

namespace ContractOnboarding.Services;

public class ContractService
{
    /// Simula la obtención de contratos desde una base de datos o API.

    public async Task<List<Contract>> GetContractsAsync()
    {
        
        // contrato de ejemplo
        var sampleContract = new Contract
        {
            ContractType = "Existing Client - New Business",
            Commodity = "Power",
            Country = "France",
            SignatureDate = new DateTime(2023, 04, 26),
            StartDate = new DateTime(2023, 01, 01),
            EndDate = new DateTime(2027, 12, 31)
        };

        // lista que contiene 2 copias de este contrato
        return new List<Contract> { sampleContract, sampleContract };
    }
}