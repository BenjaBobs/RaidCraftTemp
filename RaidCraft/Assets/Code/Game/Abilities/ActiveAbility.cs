using UnityEngine;
using System.Collections;

public class ActiveAbility : BaseAbility
{
    int minNormalAttack { get; set; }
    int maxNormalAttack { get; set; }

    public int cost { get; set; }

    //standard constructor, if nothing is known
    public ActiveAbility(string name)
    {
        this.name = name;
        minNormalAttack = 1;
        maxNormalAttack = 1; //måske andre standarder
        minRange = 0; //skal min være 0 eller 1?
        maxRange = 1;
    }

    //constructors for known attack
    public ActiveAbility(string name, int minAtt, int maxAtt)
    {
        this.name = name;
        minNormalAttack = minAtt;
        maxNormalAttack = maxAtt;
        minRange = 1;
        maxRange = 1;
    }

    //constructor for ranged abilities
    public ActiveAbility(string name, int minAtt, int maxAtt, int minRange, int maxRange)
    {
        this.name = name;
        minNormalAttack = minAtt;
        maxNormalAttack = maxAtt;
        this.minRange = minRange;
        this.maxRange = maxRange;
    }



}
