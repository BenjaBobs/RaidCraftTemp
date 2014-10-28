using UnityEngine;
using System.Collections;
using System.Collections.Generic;
   

public class BaseBuilding : MonoBehaviour {


    #region Fields
    string _name;
    BuildingType buildingType;
    int _xCoord;
    int _yCoord;
    int _width;
    int _length;
    int _goldCost;
    int _buildTimeSeconds;
    int _level;
    #endregion

    public int Level
    {
        get { return _level; }
        set { _level = value; }
    }

    public int BuildTimeSeconds
    {
        get { return _buildTimeSeconds; }
        set { _buildTimeSeconds = value; }
    }

    public int GoldCost
    {
        get { return _goldCost; }
        set { _goldCost = value; }
    }

    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public int Width
    {
        get { return _width; }
        set { _width = value; }
    }

    public BuildingType BuildingType
    {
        get { return buildingType; }
        set { buildingType = value; }
    }

    public int XCoord
    {
        get { return _xCoord; }
        set { _xCoord = value; }
    }

    public int YCoord
    {
        get { return _yCoord; }
        set { _yCoord = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
    public void MoveBuilding()
    {
        // TODO: Implement
    }
    
    public virtual void OnMoveBuilding()
    {
        //Metrics can be implemented here
    }
    
    public virtual void OnCreated()
    {
        //Metrics can be implemented here
    }


	void Start()
    {
        
    }


}
