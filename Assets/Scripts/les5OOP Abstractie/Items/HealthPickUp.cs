using System;
using UnityEngine;

public class HealthPickUp : Collectable
{
    public static event Action onHealthPickup;
    private void Start()
    {
        pickUpName ="Health";
        
        

    }
    public override void Collect()
    {
        Debug.Log ( "Health restored!");
        // to do: Health Varibaal verhogen
        onHealthPickup?.Invoke();
        
    }
}
