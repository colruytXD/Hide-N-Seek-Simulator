using UnityEngine;
using System.Collections;

public class UI_DisableLoadingScreen : MonoBehaviour {

    private GameManager_Master gameManageMasterScript;
    [SerializeField]
    private GameObject pnlLoadingScreen;
    [SerializeField]
    private GameObject pnlChoiceScreen;

	void OnEnable() 
	{
		SetInitialReferences();
        gameManageMasterScript.EventShowChoiceMenu += EnableChoiceScreen;
	}

	void OnDisable() 
	{
        gameManageMasterScript.EventShowChoiceMenu += EnableChoiceScreen;
    }

	void SetInitialReferences() 
	{
        gameManageMasterScript = GetComponent<GameManager_Master>();
	}

    void EnableChoiceScreen()
    {
        pnlLoadingScreen.SetActive(false);
        pnlChoiceScreen.SetActive(true);
    }
}
