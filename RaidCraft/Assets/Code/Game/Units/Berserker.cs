using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Berserker : BaseUnit {

	public Berserker(string customName)
    {
        health = new Attribute(Balancing.Berserker().health, "Time");
        actionPoints = new Attribute(Balancing.Berserker().actionPoints, "Turn");
        armor = new Attribute(Balancing.Berserker().armor, "Turn");
        shield = new Attribute(Balancing.Berserker().shield, "Turn");

        name = customName;
        level = 1;
        experiencePoints = 0;

        normalAttack = new ActiveAbility("Attack",
                                        Balancing.Berserker().minNormalAttack,
                                        Balancing.Berserker().maxNormalAttack,
                                        Balancing.Berserker().minRange,
                                        Balancing.Berserker().maxRange);

        activeAbilities = new List<ActiveAbility>();
        passiveAbilities = new List<PassiveAbility>();
        //abilities fikses senere.
    }
}
