using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    class DataMahasiswa_103022300100
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class JsonHelper
    {
        public static T ReadJson<T>(string filePath)
        {
            string jsonFile = File.ReadAllText(filePath);
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            T result = JsonSerializer.Deserialize<T>(jsonFile, options);

            return result;
        }
    }
}