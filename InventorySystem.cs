using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public GameObject inventoryUI;
    public Hashtable inv = new Hashtable();
    public Item pickup;

    public InventorySystem(Item item)
    {
        inv.Add(item.id, item.Obj);
    }
   

}
