
using UnityEngine;
using System.Collections.Generic;   

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private List<Item> inventory = new List<Item>();
    [SerializeField] private List <Item> itemsInWorld = new List<Item>();

    private void Start()
    {
     //  itemsInWorld.Add(new MediPack());

      
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            foreach(Item item in itemsInWorld)
            {
                if (item is MediPack) { 
                
                    inventory.Add(item);
                   
                    itemsInWorld.Remove(item);

                }
            }
            Debug.Log("Picked up MediPack");
            
        }
    }


}
