using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour 
{
	#region public feilds
    public List<GameObject> spawnables;
    public Transform PlayerPosition;
    #endregion public feilds

    #region Private Feilds
    static gameManager instance;
    #endregion Private Feilds

    public static gameManager GetInstance() // Instance used when initiated in other scripts
    {
        if (instance == null)
        {
            instance = new gameManager();
        }
        return instance;
    }
	
	void Start()
	{
		instance = this;
	}

}
 