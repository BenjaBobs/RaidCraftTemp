using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WarBringer : BaseUnit 
{

    public WarBringer(string customName)
    {
        health = new Attribute(Balancing.WarBringer().health, "Time");
        actionPoints = new Attribute(Balancing.WarBringer().actionPoints, "Turn");
        armor = new Attribute(Balancing.WarBringer().armor, "Turn");
        shield = new Attribute(Balancing.WarBringer().shield, "Turn");

        name = customName;
        level = 1;
        experiencePoints = 0;

        normalAttack = new ActiveAbility("Attack",
                                        Balancing.WarBringer().minNormalAttack,
                                        Balancing.WarBringer().maxNormalAttack,
                                        Balancing.WarBringer().minRange,
                                        Balancing.WarBringer().maxRange);

        activeAbilities = new List<ActiveAbility>();
        passiveAbilities = new List<PassiveAbility>();
        //abilities fikses senere.
    }
}
