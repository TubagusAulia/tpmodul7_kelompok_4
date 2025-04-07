using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    public class KuliahMahasiswa_103022300141
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class ListMatkul
    {
        public List<KuliahMahasiswa_103022300141> courses { get; set; }
    }

    public class JsonMatkul
    {
        public static ListMatkul ReadJson(string filePath)
        {
            string jsonFile = File.ReadAllText(filePath);

            ListMatkul result = JsonSerializer.Deserialize<ListMatkul>(jsonFile);

            return result;
        }
    }
}
