using System.IO;
using System.Xml.Serialization;
using Practice_12.Models;

public static class DataStorage
{
    private static readonly string FilePath = "BankData.xml";

    public static void SaveData(List<Client> clients)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
        using (var stream = new FileStream(FilePath, FileMode.Create))
        {
            serializer.Serialize(stream, clients);
        }
    }

    public static List<Client> LoadData()
    {
        if (!File.Exists(FilePath)) return new List<Client>();

        XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
        using (var stream = new FileStream(FilePath, FileMode.Open))
        {
            return (List<Client>)serializer.Deserialize(stream);
        }
    }
}