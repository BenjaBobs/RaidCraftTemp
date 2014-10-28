using UnityEngine;
using System.Collections;

public class WorkerBuilding : BaseBuilding
{
    #region Fields
    int _availableWorkers;
    #endregion

    public int AvailableWorkers
    {
        get { return _availableWorkers; }
        set { _availableWorkers = value; }
    }

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
