using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "items", menuName = "ScriptableObjects/items")]
public class Item : ScriptableObject
{
    public string itemName;
    public int id;
    public int inventoryIndex;
    public int damage;
    public GameObject Obj;
   
}
