using UnityEngine;

public class HealthPickUp : Collectable
{
    private void Start()
    {
        pickUpName =" Health";
        

    }
    public override void Collect()
    {
        Debug.Log ( "Health restored!");
        
    }
}
