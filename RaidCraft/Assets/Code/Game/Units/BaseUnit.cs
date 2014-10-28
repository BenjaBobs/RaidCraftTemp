using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseUnit : MonoBehaviour 
{
    public Attribute health { get; set; }
    protected Attribute actionPoints;
    public Attribute armor { get; set; }
    protected Attribute shield;
    protected string name;
    public int level { get; set; }
    protected ActiveAbility normalAttack;
    protected int experiencePoints;

    protected List<ActiveAbility> activeAbilities;
    protected List<PassiveAbility> passiveAbilities;

    [HideInInspector]
    public enum whatTeam
    {
        Team0, //friendly
        Team1, //enemy
        Team2, //friendly uncontrollable
    }

    protected void CalculateXpToLevel()
    {
        //TODO: skal den returnere int for at lave om på experiencePoints?
    }

    protected virtual void OnFallen()
    {
        //TODO: mister man xp, når man falder?
    }

    protected virtual void OnMove()
    {
        //TODO: radius eller felter?
    }

    protected virtual void OnTeamTurn()
    {

    }

    protected virtual void OnAttack()
    {

    }

    protected virtual void OnAttackComplete()
    {

    }

    protected virtual void OnAbilityUse()
    {

    }

}
