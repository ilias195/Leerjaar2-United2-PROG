using UnityEngine;

public class DamageTrap : Collectable
{
    private void Start()
    {
        pickUpName = "damageTrap";
        score -= 5;
    }
    public override void Collect()
    {
        Debug.Log(pickUpName + score + "BOOM!!");
        Die();
    }
}
