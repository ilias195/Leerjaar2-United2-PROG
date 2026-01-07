
using UnityEngine;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private List<Item> _inventory = new List<Item>();
    [SerializeField] private List<Item> _itemsInWorld = new List<Item>();

    private void Start()
    {
        //  itemsInWorld.Add(new MediPack());


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            PickUpMediPack();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            PickUpGun();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            PickUpKeycard();
        }
    }
    private void PickUpMediPack()
    {
        bool itemFound = false;

        foreach (Item item in _itemsInWorld)
        {
            if (item is MediPack)
            {
                _inventory.Add(item);
                _itemsInWorld.Remove(item);

                Debug.Log("Picked up MediPack");
                itemFound = true;
                break;
            }
        }

        if (!itemFound)
        {
            Debug.Log("No MediPack found");
        }
    }

    private void PickUpGun()
    {
        bool itemFound = false;

        foreach (Item item in _itemsInWorld)
        {
            if (item is GunItem)
            {
                _inventory.Add(item);
                _itemsInWorld.Remove(item);

                Debug.Log("Picked up Gun");
                itemFound = true;
                break;
            }
        }

        if (!itemFound)
        {
            Debug.Log("No Gun found");
        }
    }

    private void PickUpKeycard()
    {
        bool itemFound = false;

        foreach (Item item in _itemsInWorld)
        {
            if (item is Keycard)
            {
                _inventory.Add(item);
                _itemsInWorld.Remove(item);

                Debug.Log("Picked up Keycard");
                itemFound = true;
                break;
            }
        }

        if (!itemFound)
        {
            Debug.Log("No Keycard found");
        }
    }

}
