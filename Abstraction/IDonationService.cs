using System.Collections.Generic;
using Donacare.Models.PBO;

namespace Donacare.Abstractions.PBO
{
    // INTERFACE

    public interface IDonationService
    {
        bool CatatDonasi(
            KampanyePBO kampanye,
            decimal nominal
        );

        decimal HitungTotalDonasi();

        Dictionary<string, decimal>
            RekapDonasiPerKampanye();
    }
}