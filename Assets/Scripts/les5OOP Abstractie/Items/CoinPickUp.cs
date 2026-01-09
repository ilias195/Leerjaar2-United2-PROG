using System;
using UnityEngine;

public class CoinPickUp : Collectable
{
    public static event Action OnCoin;
    private void Start()
    {
        pickUpName = "Coin";
        
    }
    public override void Collect()
    {
        Debug.Log("Coin collected!");
        // to do: Score Varibaal verhogen
        OnCoin?.Invoke();

    }
}
