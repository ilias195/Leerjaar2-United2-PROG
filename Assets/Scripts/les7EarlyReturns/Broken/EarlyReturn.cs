using UnityEngine;
#if false
public class EarlyReturn : MonoBehaviour
{
    public bool IsPlayerReadyToAttack(Player player)
    {
     if (player == null) return false;
        
       //Level1
     if (!player.IsAlive) return false;

        //Level2
        if (player.AttackCooldown > 0) return false;

       //Level3
      if (player.Target == null) return false;
                   
           //Level4
        if (!player.Target.IsAlive) { return false; }
                        
         //Level5
     if (Vector3.Distance(player.transform.position, player.Target.transform.position) >= 5f) {  return false; }

        //Level6
        // Nog meer geneste conditions met && en ||
        bool ManaWeapon =
        (player.Mana >= 20 && player.WeaponEquipped);
        ManaWeapon = true;

       bool HasHealthBuff = 
       (player.Health > 30 && player.HasBuff("Strength"));
        HasHealthBuff = true;

        if (!ManaWeapon && !HasHealthBuff) {return false;}
                                
        //Level7
      if (!player.IsStunned || !player.IsSlowed) { return false;}
        return true;
                                    
         
    
}
}
#endif