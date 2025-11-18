using System.Text.Json;
using Inventory_Management.Models;


namespace InventoryManagement.Services
{
    public class DataService
    {
        private readonly string filePath;
        private readonly object fileLock = new object();

        public DataService()
        {
            filePath = Path.Combine(Directory.GetCurrentDirectory(), "data.json");
        }




        // this part is read all data from data.json 
        public DataModel ReadData()
        {
            lock (fileLock)
            {
                if (!File.Exists(filePath))
                    return new DataModel();

                var json = File.ReadAllText(filePath);
                try
                {
                    return JsonSerializer.Deserialize<DataModel>(json) ?? new DataModel();
                }
                catch
                {

                    return new DataModel();
                }
            }
        }


        // this part is write updated data back to data.json
        public void WriteData(DataModel data)
        {
            lock (fileLock)
            {
                var opts = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(data, opts);
                File.WriteAllText(filePath, json);
            }
        }
    }
}
