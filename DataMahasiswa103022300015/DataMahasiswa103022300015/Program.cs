using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

    public class Datamahasiswa {
    public class Mahasiswa()
    { 

    public string nama {  get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }
    }

    public void ReadJSON() 
    {
        string filePath = "tp7_1_103022300015.json";
        string json = File.ReadAllText(filePath);

        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(json);

        Console.WriteLine($"Nama {mhs.nama} nim {mhs.nim} fakultas {mhs.fakultas}");
    }
}
