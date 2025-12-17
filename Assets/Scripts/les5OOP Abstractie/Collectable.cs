using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    
    protected int score;
    protected string pickUpName;
    public abstract void Collect();
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }

   
    protected void Die()
    {
        Debug.Log( "score afname" + score);
        Destroy(gameObject);
        Debug.Log("die");

    }



}
