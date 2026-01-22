using UnityEngine;

public class Phoenix : Enemy
{
    private void Start()
    {
        gameObject.name = "[Phoenix]";
        health = 120f;
        // Stel health/speed in als nodig
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        health += 20f;
        Debug.Log("Phoenix attacks and heals itself! Health: " + health);
    }

    public override void TakeDamage(float damage)
    {
        damage = 30f;  
        base.TakeDamage(damage);
    }

}
