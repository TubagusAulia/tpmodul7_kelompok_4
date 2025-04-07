using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022300047
{
	public class Mahasiswa
	{
		public string nim { get; set; }
		public string nama { get; set; } 
		public string fakultas { get; set; }
    }

	public void ReadJSON()
	{
		string jsonString = File.ReadAllText("tp7_1_103022300047.json");
		Mahasiswa mahasiswa = JsonSerializer.Deserialize<mahasiswa>(jsonString);	
		Console.WriteLine($"Nama {mhs.nama} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
    }
}

