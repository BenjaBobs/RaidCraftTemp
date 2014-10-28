using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Juggernaut : BaseUnit {

	public Juggernaut(string customName)
    {
        health = new Attribute(Balancing.Juggernaut().health, "Time");
        actionPoints = new Attribute(Balancing.Juggernaut().actionPoints, "Turn");
        armor = new Attribute(Balancing.Juggernaut().armor, "Turn");
        shield = new Attribute(Balancing.Juggernaut().shield, "Turn");

        name = customName;
        level = 1;
        experiencePoints = 0;

        normalAttack = new ActiveAbility("Attack",
                                        Balancing.Juggernaut().minNormalAttack,
                                        Balancing.Juggernaut().maxNormalAttack,
                                        Balancing.Juggernaut().minRange,
                                        Balancing.Juggernaut().maxRange);

        activeAbilities = new List<ActiveAbility>();
        passiveAbilities = new List<PassiveAbility>();
        //abilities fikses senere.
    }
}
