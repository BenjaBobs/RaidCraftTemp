﻿using UnityEngine;
using System.Collections;

public class BaseStorageBuilding : BaseBuilding
{

    #region Fields
    int _currentAmount;
    int _maxCapacity;
    #endregion

    public int MaxCapacity
    {
        get { return _maxCapacity; }
        set { _maxCapacity = value; }
    }

    public int CurrentAmount
    {
        get { return _currentAmount; }
        set { _currentAmount = value; }
    }

    public virtual void OnMaxCapacityReached()
    {

    }

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
