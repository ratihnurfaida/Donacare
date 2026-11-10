namespace Donacare.Models.PBO
{
    // ENCAPSULATION: menggunakan get dan set
    // INHERITANCE: mewarisi BaseEntity

    public class PenggunaPBO : BaseEntity
    {
        public string Nama { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Role { get; set; } = "Student";
    }
}