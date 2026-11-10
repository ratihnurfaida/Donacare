using System;
using System.Collections.Generic;
using Donacare.Abstractions.PBO;

namespace Donacare.Services.PBO
{
    // GENERIC CLASS

    public class GenericRepository<T> : IRepository<T>
        where T : class
    {
        // COLLECTION: List<T>
        private readonly List<T> _items = new();

        public void Tambah(T item)
        {
            ArgumentNullException.ThrowIfNull(item);

            _items.Add(item);
        }

        public List<T> AmbilSemua()
        {
            return new List<T>(_items);
        }

        public bool Hapus(Predicate<T> kondisi)
        {
            ArgumentNullException.ThrowIfNull(kondisi);

            T? item = _items.Find(kondisi);

            return item != null && _items.Remove(item);
        }
    }
}