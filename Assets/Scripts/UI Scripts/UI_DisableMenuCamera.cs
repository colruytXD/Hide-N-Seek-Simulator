using UnityEngine;
using System.Collections;

public class UI_DisableMenuCamera : MonoBehaviour {

    private GameManager_Master gameManagerMaster;
    [SerializeField]
    private GameObject menuCamera;

	void OnEnable() 
	{
        SetInitialReferences();
        gameManagerMaster.EventDisableMenuCamera += DisableMenuCamera;
	}

	void OnDisable() 
	{
        gameManagerMaster.EventDisableMenuCamera -= DisableMenuCamera;
    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManager_Master>();
    }

    void DisableMenuCamera()
    {
        menuCamera.SetActive(false);
    }
}
