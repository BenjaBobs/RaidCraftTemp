using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Archer : BaseUnit
{

    public Archer(string customName)
    {
        health = new Attribute(Balancing.Archer().health, "Time");
        actionPoints = new Attribute(Balancing.Archer().actionPoints, "Turn");
        armor = new Attribute(Balancing.Archer().armor, "Turn");
        shield = new Attribute(Balancing.Archer().shield, "Turn");

        name = customName;
        level = 1;
        experiencePoints = 0;

        normalAttack = new ActiveAbility("Attack", 
                                        Balancing.Archer().minNormalAttack, 
                                        Balancing.Archer().maxNormalAttack,
                                        Balancing.Archer().minRange,
                                        Balancing.Archer().maxRange);

        activeAbilities = new List<ActiveAbility>();
        passiveAbilities = new List<PassiveAbility>();
        //abilities fikses senere.
    }
}
