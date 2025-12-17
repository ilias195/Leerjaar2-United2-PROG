using UnityEngine;

public class HealthPickUp : Collectable
{
    private void Start()
    {
        pickUpName =" health";
        score = 20;

    }
    public override void Collect()
    {
        Debug.Log (pickUpName + score + "Health restored!");
        Die();
    }
}
