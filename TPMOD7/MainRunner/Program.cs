using System;

using DataMahasiswa103022300015Namespace;
using KuliahMahasiswa103022300015Namespace;

namespace MainRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Baca Data Mahasiswa ===");
            var data = new Datamahasiswa();
            data.ReadJSON();

            Console.WriteLine();
            Console.WriteLine("=== Baca Daftar Mata Kuliah ===");
            var kuliah = new KuliahMahasiswa103022300015();
            kuliah.ReadJSON();

            Console.WriteLine();
            Console.WriteLine("Selesai menjalankan MainRunner.");
        }
    }
}
