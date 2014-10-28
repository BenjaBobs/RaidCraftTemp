using UnityEngine;
using System.Collections;

public class FarmBuilding
    : BaseStorageBuilding
{

    #region Fields
    float _secondsPerFood;
    #endregion


    public float SecondsPerFood
    {
        get { return _secondsPerFood; }
        set { _secondsPerFood = value; }
    }


    public void Harvest()
    {
        // TODO: Implement
        CurrentAmount = 0;
    }

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
