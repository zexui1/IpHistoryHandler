using System.IO.IsolatedStorage;
using System.Text.Json;
using System.Diagnostics;

namespace IpHandler
{
    internal class StorageHandler
    {

        public static void SaveDataInStorage(List<Ip> ips)
        {
            List<Ip> oldIps = ReadDataInStorage();

            IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication();

            if (!isolatedStorageFile.FileExists("Data.txt"))
            {
                IsolatedStorageFileStream isolatedStorageFileMaker = new IsolatedStorageFileStream("Data.txt", FileMode.Create, isolatedStorageFile);
                isolatedStorageFileMaker.Dispose();
            }

            IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("Data.txt",FileMode.Open,isolatedStorageFile);


            using (StreamWriter writer = new StreamWriter(isolatedStorageFileStream))
            {
                foreach (Ip ip in ips)
                {
                    if (!oldIps.Any(x=>x.ip == ip.ip))
                    {
                        writer.WriteLine(JsonSerializer.Serialize(ip));
                    }
                }
            }
            isolatedStorageFile.Dispose();
        }

        public static List<Ip> ReadDataInStorage()
        {
            List<Ip> ips = new List<Ip>();
            IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication();

            if (!isolatedStorageFile.FileExists("Data.txt"))
            {
                IsolatedStorageFileStream isolatedStorageFileMaker = new IsolatedStorageFileStream("Data.txt", FileMode.Create, isolatedStorageFile);
                isolatedStorageFileMaker.Dispose();
            }

            IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("Data.txt", FileMode.Open, isolatedStorageFile);

            using (StreamReader reader = new StreamReader(isolatedStorageFileStream))
            {
                string raw = reader.ReadLine();
                if (!string.IsNullOrEmpty(raw))
                {
                    ips.Add(JsonSerializer.Deserialize<Ip>(raw));
                }
            }

            isolatedStorageFile.Dispose();
            return ips;
        }

        public static void ClearDataInStorage()
        {
            IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication();
            if (isolatedStorageFile.FileExists("Data.txt"))
            {
                isolatedStorageFile.DeleteFile("Data.txt");
                isolatedStorageFile.Dispose();

            }
        }
    }
}
