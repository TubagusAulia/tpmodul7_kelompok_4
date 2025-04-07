using System;
using System.IO;

namespace tpmodul7_kelompok_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // JSON Deserialization 1
            string filePath1 = "tp7_1_103022300141.json";
            var data = JsonHelper.ReadJson<DataMahasiswa_103022300141>(filePath1);
            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");

            // JSON Deserialization 2
            string filePath2 = "tp7_2_103022300141.json";
            var matkulData = JsonMatkul.ReadJson(filePath2);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in matkulData.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
