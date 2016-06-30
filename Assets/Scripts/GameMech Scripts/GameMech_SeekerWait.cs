using UnityEngine;
using System.Collections;

public class GameMech_SeekerWait : Photon.MonoBehaviour {

    private GameManager_Master gameManagerMasterScript;
    private Network_SpawnPlayer spawnPlayerScript;

    [SerializeField]
    private GameObject pnlHiding;
    [SerializeField]
    private GameObject pnlChoices;
    public float waitTime = 20;

	void OnEnable() 
	{
		SetInitialReferences();
	}

	void OnDisable() 
	{

	}

	void SetInitialReferences() 
	{
        gameManagerMasterScript = GetComponent<GameManager_Master>();
        spawnPlayerScript = GameObject.FindGameObjectWithTag("NetworkHandler").GetComponent<Network_SpawnPlayer>();
	}

    //Waits ten seconds, then disables hiding panel
    public void EnableHidingPanel()
    {
        StartCoroutine(Waiter());
    }

    IEnumerator Waiter()
    {
        pnlChoices.SetActive(false);
        pnlHiding.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        pnlHiding.SetActive(false);
        spawnPlayerScript.ChoiceSeeker();
    }
}
