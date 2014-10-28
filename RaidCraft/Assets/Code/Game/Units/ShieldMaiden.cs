using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShieldMaiden : BaseUnit {

	public ShieldMaiden(string customName)
    {
        health = new Attribute(Balancing.ShieldMaiden().health, "Time");
        actionPoints = new Attribute(Balancing.ShieldMaiden().actionPoints, "Turn");
        armor = new Attribute(Balancing.ShieldMaiden().armor, "Turn");
        shield = new Attribute(Balancing.ShieldMaiden().shield, "Turn");

        name = customName;
        level = 1;
        experiencePoints = 0;

        normalAttack = new ActiveAbility("Attack",
                                        Balancing.ShieldMaiden().minNormalAttack,
                                        Balancing.ShieldMaiden().maxNormalAttack,
                                        Balancing.ShieldMaiden().minRange,
                                        Balancing.ShieldMaiden().maxRange);

        activeAbilities = new List<ActiveAbility>();
        passiveAbilities = new List<PassiveAbility>();
        //abilities fikses senere.
    }
}
