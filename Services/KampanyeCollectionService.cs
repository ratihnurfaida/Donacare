using System;
using System.Collections.Generic;
using System.Linq;
using Donacare.Models.PBO;

namespace Donacare.Services.PBO
{
    public class KampanyeCollectionService
    {
        // COLLECTION
        private readonly List<KampanyePBO> _kampanye = new();

        public void Tambah(KampanyePBO kampanye)
        {
            ArgumentNullException.ThrowIfNull(kampanye);

            _kampanye.Add(kampanye);
        }

        public List<KampanyePBO> AmbilSemua()
        {
            return _kampanye.ToList();
        }

        // DICTIONARY
        public Dictionary<string, int> HitungJumlahPerStatus(
            Func<KampanyePBO, string> penentuStatus
        )
        {
            ArgumentNullException.ThrowIfNull(penentuStatus);

            return _kampanye
                .GroupBy(penentuStatus)
                .ToDictionary(
                    g => g.Key,
                    g => g.Count()
                );
        }
    }
}