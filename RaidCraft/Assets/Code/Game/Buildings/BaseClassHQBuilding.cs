using UnityEngine;
using System.Collections;

public class BaseClassHQBuilding : BaseBuilding {

	#region Fields
	int _currentUnits;
	int _maxUnits;
	int _unitCost;
	int _unitTrainTimeSeconds;
	#endregion

	public int CurrentUnits
	{
		get{return _currentUnits;} 
		set{ _currentUnits= value;}
	}

	public int MaxUnits
	{
		get{return _maxUnits;} 
		set{ _maxUnits = value;}
	}

	public int UnitCost
	{
		get{return _unitCost;} 
		set{ _unitCost = value;}
	}

	public int UnitTrainTimeSeconds
	{
		get{return _unitTrainTimeSeconds;} 
		set{ _unitTrainTimeSeconds = value;}
	}

	public void TrainNew()
	{

	}

	public void OnStartUnitTraining()
	{

	}

	public void OnCancelUnittraining()
	{

	}

	public void OnUnitTrained()
	{

	}

}
