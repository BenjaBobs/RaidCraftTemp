using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Collider))]
public class BuildTile : MonoBehaviour
{

    #region Fields
    [SerializeField]
    Material OccupiedMaterial;
    [SerializeField]
    Material VacantMaterial;
    [SerializeField]
    Material NormalMaterial;

    int _xCoord;
    int _yCoord;
    
    Renderer rend;
    bool _buildMode;
    #endregion

    public int YCoord
    {
        get { return _yCoord; }
        set { _yCoord = value; }
    }

    public int XCoord
    {
        get { return _xCoord; }
        set { _xCoord = value; }
    }

    public bool BuildMode
    {
        get { return _buildMode; }
        set 
        { 
            _buildMode = value; 
            if (value == true)
            {
                rend.material = VacantMaterial;
            }
            else
            {
                rend.material = NormalMaterial;
            }
        }
    }

    

    void Awake()
    {
        
    }

	// Use this for initialization
	void Start () {
        BuildGrid.RegisterTile(this, 0, 0);
        rend = renderer;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            BuildMode = !BuildMode;
        }
	    
	}

    
}
