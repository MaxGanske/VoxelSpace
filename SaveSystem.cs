using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
   public static void SavePlayer(SavingCenter player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.stats";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static void SaveInventory(Item data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.inventory";
        FileStream stream = new FileStream(path, FileMode.Create);

        InventorySystem inventory = new InventorySystem(data);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.stats";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;

        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    public static InventorySystem LoadInventory()
    {
        string path = Application.persistentDataPath + "/player.inventory";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            InventorySystem data = formatter.Deserialize(stream) as InventorySystem;
            stream.Close();

            return data;

        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

}
