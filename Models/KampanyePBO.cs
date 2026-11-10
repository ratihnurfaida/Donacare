
using System;

namespace Donacare.Models.PBO
{
    public class KampanyePBO : BaseEntity
    {
        public string NamaKampanye { get; set; }
            = string.Empty;

        public decimal TargetDana { get; set; }

        public decimal DanaTerkumpul { get; set; }

        public decimal HitungKekuranganDana()
        {
            return Math.Max(
                0,
                TargetDana - DanaTerkumpul
            );
        }
    }
}
