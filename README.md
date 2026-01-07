## Les 1 CodeConventies
![les1CodeConventies](https://github.com/user-attachments/assets/4e4f835d-bf56-4dc3-908e-c39accec93a6)

in deze opdracht hebben we **InventorySystem** gemaakt in Unity. Controls zijn:
- Keycode(M) = MediPacks
- Keycode(G) = Guns
- Keycode (K) - Keycode

### hoe heb ik het aangepakt? 
ik heb gewerkt met **Abstracte** code wat we in Opdracht 5 gaan behandelen.
hierdoor kan mijn verschillende codes aangeven dat ze een naamgeving bijvoorbeeld moet hebben zodat de code over-
zichtelijk blijft en dat het niet rommelig. Hierdoor kan ik ook snel mijn fout zien wat mijn code werkt dan niet.

Vervolgens heb ik ook gebruikt gemaakt wat ik geleerd heb bij Opdracht 7. ik heb gebruik gemaakt van een **break**. Dat
houd in dat hij langs de statements gaat en als de Statement is geweest stopt die. en gaat die naar de volgende. Hierdoor
voorkom ik dat MediaPacks twee keer bijvoorbeeld wordt gepakt, want anders komt ie niet bij de Keycode of Guns aan.

Ten slot heb ik ook gebruikt gemaakt van  **naamgevingsconventies**,zodat je snel kan zien wat het is. Bijvoorbeeld:
-Private 
-Functie
-Class
Hierdoor houd je een overzicht.

[Bekijk hier mijn codes voor mijn Inventory](https://github.com/ilias195/Leerjaar2-United2-PROG/tree/main/Assets/Scripts/01-Code-Conventies/Inventory)

[Bekijk hier mijn codes voor mijn Items](https://github.com/ilias195/Leerjaar2-United2-PROG/tree/main/Assets/Scripts/01-Code-Conventies/Items)


## les 2

## les 3 Data Structures
![InventorySystem](https://github.com/user-attachments/assets/b57b531b-bac0-4959-8680-6b84cb2c6278)

In deze Gifje kun je zien dat je met  ItemTemplates spullen kunt maken. Een item heeft een naam, soort, stats, prijs en een plaatje. 
Met een druk op de knop (SpaceBar) kun je een echt item maken en je kunt zien wat het doet in de console.
Zo is het makkelijk om nieuwe spullen te maken en te gebruiken in het spel.

[bekijk mijn scripts](https://github.com/ilias195/Leerjaar2-United2-PROG/tree/main/Assets/Scripts/03-Data-Structers)



## les 7 Early Returns
Dit script laat ik zien hoe je "early returns" gebruikt om ingewikkelde "if statement-logica"leesbaar te houden.

```csharp
using UnityEngine;

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
```
[Klik hier om de script te zien](https://github.com/ilias195/Leerjaar2-United2-PROG/tree/main/Assets/Scripts/les7EarlyReturns/Broken)
