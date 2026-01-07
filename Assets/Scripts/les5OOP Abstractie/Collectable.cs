using System;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    
    protected int score;
    protected string pickUpName;

    public static event Action<Collectable> OnCollected;
    public abstract void Collect();
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Collect();

        if (OnCollected != null)
        {
            OnCollected.Invoke(this);
        };

       
        Destroy(gameObject);
    }



}
