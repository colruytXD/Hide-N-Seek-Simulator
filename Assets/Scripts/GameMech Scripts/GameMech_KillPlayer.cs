using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class GameMech_KillPlayer : MonoBehaviour {

    private GameManager_Master gameManagerMasterScript;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMasterScript.EventPlayerDied += KillPlayer;
    }

	void OnDisable() 
	{
        gameManagerMasterScript.EventPlayerDied -= KillPlayer;
    }

	void SetInitialReferences() 
	{
        gameManagerMasterScript = GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameManager_Master>();
	}

    void KillPlayer()
    {
        gameObject.GetComponent<FirstPersonController>().enabled = false;
        PhotonNetwork.Destroy(gameObject);
    }
}
