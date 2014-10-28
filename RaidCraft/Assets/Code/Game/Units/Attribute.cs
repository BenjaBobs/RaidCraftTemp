using UnityEngine;
using System.Collections;

//attributes are used for basic attributes, such as life, shield etc
public class Attribute : MonoBehaviour {

    enum ResetCondition
    {
        None,
        Turn,
        Battle,
        Time
    };

    public int currentValue;
    public int baseValue { get; private set; } //ved ikke, om vi kommer til at ændre på det..
    ResetCondition condition;
    public float startTimer;


    public Attribute(int baseVal, string resetcond)
    {
        baseValue = baseVal;

        switch(resetcond)
        {
            case "None":
                condition = ResetCondition.None;
                break;
            case "Turn":
                condition = ResetCondition.Turn;
                break;
            case "Battle":
                condition = ResetCondition.Battle;
                break;
            case "Time":
                condition = ResetCondition.Time;
                startTimer = Time.time; //if current time is more than startTimer + 15xlevel minutes, regenerate.
                break;
            default:
                condition = ResetCondition.None;
                break;
        }
    }
}
