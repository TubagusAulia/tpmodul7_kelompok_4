using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace KuliahMahasiswa103022300015Namespace
{
    public class KuliahMahasiswa103022300015
    {
        public class MataKuliah
        {
            public string kode { get; set; }
            public string nama { get; set; }
        }

        public class DaftarKuliah
        {
            public List<MataKuliah> MataKuliah { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "tp7_2_103022300015.json";
            string jsonContent = File.ReadAllText(filePath);

            DaftarKuliah daftar = JsonSerializer.Deserialize<DaftarKuliah>(jsonContent);

            Console.WriteLine("Daftar mata kuliah: ");
            int i = 1;
            foreach (var mk in daftar.MataKuliah)
            {
                Console.WriteLine($"MK {i} {mk.kode} - {mk.nama}");
                i++;
            }
        }
    }
}
