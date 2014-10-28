using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StandardUnit : BaseUnit 
{

	public StandardUnit(string customName)
    {
        health = new Attribute(Balancing.StandardUnit().health, "Time");
        actionPoints = new Attribute(Balancing.StandardUnit().actionPoints, "Turn");
        armor = new Attribute(Balancing.StandardUnit().armor, "Turn");
        shield = new Attribute(Balancing.StandardUnit().shield, "Turn");

        name = customName;
        level = 1;
        experiencePoints = 0;

        normalAttack = new ActiveAbility("Attack",
                                        Balancing.StandardUnit().minNormalAttack,
                                        Balancing.StandardUnit().maxNormalAttack,
                                        Balancing.StandardUnit().minRange,
                                        Balancing.StandardUnit().maxRange);

        activeAbilities = new List<ActiveAbility>();
        passiveAbilities = new List<PassiveAbility>();
        //abilities fikses senere.
    }
}
