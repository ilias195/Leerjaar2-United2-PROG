using UnityEngine;
using System.Collections.Generic;

public class PlayerStats : MonoBehaviour
{
    private int _score = 0;
    private int _health =20;

    private void Start()
    {
        HealthPickUp.onHealthPickup += AddHealth;
        DamageTrap.OnDamage += RemoveDamage;
        CoinPickUp.OnCoin += AddCoin;
    }

     private void AddHealth()
    {
        _health += 20;
        Debug.Log("Health" + _health);
    }
    
    private void RemoveDamage()
    {
        _health -= 5;
        Debug.Log("Health" + _health);
    }

    private void AddCoin()
    {
        _score += 10;
        Debug.Log("Score" + _score);
    }
}
