using UnityEngine;

public class CoinPickUp : Collectable
{
    private void Start()
    {
        pickUpName = "Coin";
        score = 10;
    }
    public override void Collect()
    {
        Debug.Log(pickUpName + score + "Coin collected!");
        Die();
        
    }
}
