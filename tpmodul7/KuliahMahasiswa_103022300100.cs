using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7
{
    public class KuliahMahasiswa_103022300100
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class ListMatkul
    {
        public List<KuliahMahasiswa_103022300100> courses { get; set; }
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
