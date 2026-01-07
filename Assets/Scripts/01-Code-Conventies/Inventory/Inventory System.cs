
using UnityEngine;
using System.Collections.Generic;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private List<ItemLes1> _inventory = new List<ItemLes1>();
    [SerializeField] private List<ItemLes1> _itemsInWorld = new List<ItemLes1>();


    private void Start()
    {
        Debug.Log("InventorySystem started");
        _itemsInWorld.Add(new MediPack());
        _itemsInWorld.Add(new GunItem());
        _itemsInWorld.Add(new Keycard());


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

        foreach (ItemLes1 item in _itemsInWorld)
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

        foreach (ItemLes1 item in _itemsInWorld)
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

        foreach (ItemLes1 item in _itemsInWorld)
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
