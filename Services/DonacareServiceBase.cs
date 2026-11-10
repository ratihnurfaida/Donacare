namespace Donacare.Services.PBO
{
    // ABSTRACT CLASS

    public abstract class DonacareServiceBase
    {
        // Abstract method
        public abstract string Proses();

        // Virtual method
        public virtual string NamaModul()
        {
            return "Modul Donacare";
        }
    }
}