using UnityEngine;
using System.Collections;

//Abilities are both special abilities and normal attacks. 
//See ActiveAbility and PassiveAbility
public class BaseAbility : MonoBehaviour {

    protected string name;
    protected int minRange { get; set; }
    protected int maxRange { get; set; }

}
