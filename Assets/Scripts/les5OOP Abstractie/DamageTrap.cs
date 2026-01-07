using UnityEngine;

public class DamageTrap : Collectable
{
    private void Start()
    {
        pickUpName = "damageTrap";
       
    }
    public override void Collect()
    {
        Debug.Log( "BOOM!!");
        
    }
}
