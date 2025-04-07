using System;
using System.IO;

namespace tpmodul7_kelompok_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "tp7_1_103022300141.json";
            var data = JsonHelper.ReadJson<DataMahasiswa_103022300141>(filePath);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
    }
}
