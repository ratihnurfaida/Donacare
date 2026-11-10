using Microsoft.EntityFrameworkCore;

namespace Donacare.Data
{
    public class DonacareContext : DbContext
    {
        public DonacareContext(
            DbContextOptions<DonacareContext> options)
            : base(options)
        {
        }
    }
}