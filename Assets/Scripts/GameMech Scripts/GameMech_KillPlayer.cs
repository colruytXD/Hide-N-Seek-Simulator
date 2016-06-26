using UnityEngine;
using System.Collections;

public class GameMech_KillPlayer : MonoBehaviour {

    private GameManager_Master gameManagerMasterScript;

	void OnEnable() 
	{
		SetInitialReferences();
	}

	void OnDisable() 
	{

	}
	
	void Update () 
	{
	
	}

	void SetInitialReferences() 
	{
        gameManagerMasterScript = GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameManager_Master>();
	}
}
