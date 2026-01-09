using System;
using UnityEngine;

public class DamageTrap : Collectable
{
    public static event Action OnDamage;
    private void Start()
    {
        pickUpName = "damageTrap";
       
    }
    public override void Collect()
    {
        Debug.Log( "BOOM!!");
        // to do: Health Varibaal Verlagen
        OnDamage?.Invoke();

    }
}
