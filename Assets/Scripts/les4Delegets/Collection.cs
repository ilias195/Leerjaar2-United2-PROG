using System;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public static event Action<int> Oncollected;
    [SerializeField] private int _scoreValu = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        {
            Oncollected?.Invoke(_scoreValu);
            Destroy(gameObject);
            
        }


    }
}
