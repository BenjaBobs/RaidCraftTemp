using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BuildGrid : MonoBehaviour {

    public static BuildGrid staticRef;
    
    #region Fields
    [SerializeField]
    int _xMax;
    [SerializeField]
    int _yMax;
    #endregion

    BuildTile[,] tiles;

    void Awake()
    {
        staticRef = this;
        tiles = new BuildTile[_xMax,_yMax];
    }

    void Start()
    {
    }

    public static void RegisterTile(BuildTile tile, int x, int y)
    {
        if (x >= 0 && x < staticRef._xMax)
            if (y >= 0 && y < staticRef._yMax)
                staticRef.tiles[x, y] = tile;
    }

    public static void SetBuildMode(bool buildMode)    
    {
        for (int i = 0; i < staticRef._xMax; i++)
        {
            for (int j = 0; j < staticRef._yMax; j++)
            {
                if (staticRef.tiles[i, j] != null)
                    staticRef.tiles[i, j].BuildMode = buildMode;
            }

        }
    }
        
    
    
}
