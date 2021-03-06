﻿using UnityEngine;
using System.Collections;

public class GameManager_EnableDeathScreen : Photon.MonoBehaviour {

    private GameObject deathCamera;
    private GameManager_Master gameManagerMasterScript;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMasterScript.EventPlayerDied += EnableDeathScreen;
	}

	void OnDisable() 
	{
        gameManagerMasterScript.EventPlayerDied -= EnableDeathScreen;
    }

	void SetInitialReferences() 
	{
        gameManagerMasterScript = GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameManager_Master>();
        deathCamera = GameObject.FindGameObjectWithTag("DeathCamera");
	}

    void EnableDeathScreen()
    {
            deathCamera.SetActive(true);
    }
}
