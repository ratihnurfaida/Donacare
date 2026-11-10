
using System;
using System.Collections.Generic;

namespace Donacare.Abstractions.PBO
{
    // GENERIC + INTERFACE

    public interface IRepository<T>
        where T : class
    {
        void Tambah(T item);

        List<T> AmbilSemua();

        bool Hapus(Predicate<T> kondisi);
    }
}
