using System;

namespace Donacare.Models.PBO
{
    // INHERITANCE
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;
    }
}