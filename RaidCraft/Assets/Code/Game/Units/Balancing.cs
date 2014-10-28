using UnityEngine;
using System.Collections;

public class Balancing : MonoBehaviour 
{
    public static Balancing staticRef;

    public void Awake()
    {
        staticRef = this;
    }

    public ArcherModifier archerMod;
    public static ArcherModifier Archer()
    {
        return staticRef.archerMod;
    }

    public BerserkerModifier berserkerMod;
    public static BerserkerModifier Berserker()
    {
        return staticRef.berserkerMod;
    }

    public JuggernautModifier juggernautMod;
    public static JuggernautModifier Juggernaut()
    {
        return staticRef.juggernautMod;
    }

    public ShieldMaidenModifier shieldMaidenMod;
    public static ShieldMaidenModifier ShieldMaiden()
    {
        return staticRef.shieldMaidenMod;
    }

    public WarBringerModifier warBringerMod;
    public static WarBringerModifier WarBringer()
    {
        return staticRef.warBringerMod;
    }

    public StandardUnitModifier standardUnitMod;
    public static StandardUnitModifier StandardUnit()
    {
        return staticRef.standardUnitMod;
    }

    [System.Serializable]
    public class ArcherModifier
    {
        public int health = 7;
        public int actionPoints = 4;
        public int minNormalAttack = 1;
        public int maxNormalAttack = 2;
        public int minRange = 3;
        public int maxRange = 5;
        public int armor = 0;
        public int shield = 0;
    }

    [System.Serializable]
    public class BerserkerModifier
    {
        public int health = 10;
        public int actionPoints = 5;
        public int minNormalAttack = 2;
        public int maxNormalAttack = 3;
        public int minRange = 1;
        public int maxRange = 1;
        public int armor = 1;
        public int shield = 0;
    }

    [System.Serializable]
    public class JuggernautModifier
    {
        public int health = 12;
        public int actionPoints = 3;
        public int minNormalAttack = 3;
        public int maxNormalAttack = 6;
        public int minRange = 1;
        public int maxRange = 1;
        public int armor = 2;
        public int shield = 0;
    }

    [System.Serializable]
    public class ShieldMaidenModifier
    {
        public int health = 20;
        public int actionPoints = 4;
        public int minNormalAttack = 2;
        public int maxNormalAttack = 3;
        public int minRange = 1;
        public int maxRange = 1;
        public int armor = 2;
        public int shield = 25;
    }

    [System.Serializable]
    public class WarBringerModifier
    {
        public int health = 8;
        public int actionPoints = 5;
        public int minNormalAttack = 1;
        public int maxNormalAttack = 2;
        public int minRange = 1;
        public int maxRange = 1;
        public int armor = 0;
        public int shield = 0;
    }

    [System.Serializable]
    public class StandardUnitModifier
    {
        public int health = 10;
        public int actionPoints = 4;
        public int minNormalAttack = 1;
        public int maxNormalAttack = 2;
        public int minRange = 1;
        public int maxRange = 1;
        public int armor = 0;
        public int shield = 0;
    }
}
