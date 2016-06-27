using UnityEngine;
using System.Collections;

public class GameManager_CursorLock : MonoBehaviour {

    private GameManager_Master gameManagerMasterScript;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManagerMasterScript.EventPlayerDied += EnableCursor;
	}

	void OnDisable() 
	{
        gameManagerMasterScript.EventPlayerDied -= EnableCursor;
    }

	void SetInitialReferences() 
	{
        gameManagerMasterScript = GetComponent<GameManager_Master>();
	}

    void EnableCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void DisableCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
