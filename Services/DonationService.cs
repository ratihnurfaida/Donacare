using System;
using System.Collections.Generic;
using System.Linq;
using Donacare.Abstractions.PBO;
using Donacare.Models.PBO;

namespace Donacare.Services.PBO
{
    // INHERITANCE + INTERFACE

    public class DonationService :
        DonacareServiceBase,
        IDonationService
    {
        // COLLECTION
        private readonly List<(string Kampanye, decimal Nominal)>
            _transaksi = new();

        // Method mencatat donasi
        public bool CatatDonasi(
            KampanyePBO kampanye,
            decimal nominal
        )
        {
            ArgumentNullException.ThrowIfNull(kampanye);

            if (nominal <= 0 ||
                string.IsNullOrWhiteSpace(kampanye.NamaKampanye))
            {
                return false;
            }

            _transaksi.Add(
                (kampanye.NamaKampanye, nominal)
            );

            kampanye.DanaTerkumpul += nominal;

            return true;
        }

        // Menghitung seluruh donasi
        public decimal HitungTotalDonasi()
        {
            return _transaksi.Sum(x => x.Nominal);
        }

        // DICTIONARY
        public Dictionary<string, decimal>
            RekapDonasiPerKampanye()
        {
            return _transaksi
                .GroupBy(x => x.Kampanye)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(x => x.Nominal)
                );
        }

        // Implementasi abstract method
        public override string Proses()
        {
            return $"Total donasi tercatat: " +
                $"{HitungTotalDonasi():N0}";
        }

        public override string NamaModul()
        {
            return "Layanan Donasi Donacare";
        }
    }
}