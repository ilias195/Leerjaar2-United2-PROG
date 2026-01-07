using UnityEngine;

public class HealthPickUp : Collectable
{
    private void Start()
    {
        pickUpName =" health";
        

    }
    public override void Collect()
    {
        Debug.Log ( "Health restored!");
        
    }
}
