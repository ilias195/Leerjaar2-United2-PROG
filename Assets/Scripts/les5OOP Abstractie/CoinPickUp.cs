using UnityEngine;

public class CoinPickUp : Collectable
{
    private void Start()
    {
        pickUpName = "Coin";
        
    }
    public override void Collect()
    {
        Debug.Log("Coin collected!");
        
        
    }
}
