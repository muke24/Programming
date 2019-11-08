using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class Save
{
    public static void SavePlayerData(PlayerManager player)
    {
        // Reference to binary formatter
        BinaryFormatter formatter = new BinaryFormatter();
        // Path to save to
        string path = Application.persistentDataPath + "/Save.png";
        // File stream create file at path
        FileStream stream = new FileStream(path, FileMode.Create);
        // DataToSave with player info
        DataToSave data = new DataToSave(player);
        // Format and serialize location and data
        formatter.Serialize(stream, data);
        // End
        stream.Close();
    }

    public static DataToSave LoadPlayerData()
    {
        string path = Application.persistentDataPath + "/Save.png";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            DataToSave data = formatter.Deserialize(stream) as DataToSave;
            stream.Close();
            return data;

        }
        else
        {
            Debug.Log("Couldn't find file to load");
            return null;
        }
    }

}
