using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingCenter : MonoBehaviour
{
    public GameObject player;
    public Hashtable inv;
    public Item item;


    private void Start()
    {
        player.transform.position = new Vector3(3110, 306, -778);
        

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SavePlayer();
            SaveInventory();
            Debug.Log("game has been saved");

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadPlayer();
            LoadInventory();
            Debug.Log("Game has been loaded");
            Debug.Log(inv[1].ToString());

        }

    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void SaveInventory()
    {
        SaveSystem.SaveInventory(item);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Vector3 position;
        position.x = data.playerPosition[0];
        position.y = data.playerPosition[1];
        position.z = data.playerPosition[2];
        transform.position = position;
        
    }
    public void LoadInventory()
    {
        InventorySystem data = SaveSystem.LoadInventory();

        inv = data.inv;
    }
    
}
