using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            DataMahasiswa_103022300100 mahasiswa = JsonHelper.ReadJson<DataMahasiswa_103022300100>("tp7_1_103022300100.json");
            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");

            ListMatkul list = JsonMatkul.ReadJson("tp7_2_103022300100.json");
            int i = 1;
            Console.WriteLine("\nDaftar Mata Kuliah Yang Diambil:");
            foreach (var matkul in list.courses)
            {
                Console.WriteLine($"MK {i} {matkul.code} - {matkul.name}");
                i++;
            }
        }
    }
}
