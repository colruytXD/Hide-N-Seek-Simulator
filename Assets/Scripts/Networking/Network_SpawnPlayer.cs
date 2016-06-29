using UnityEngine;
using System.Collections;

public class Network_SpawnPlayer : Photon.MonoBehaviour {

    private Networking_Master networkingMasterScript;
    private GameManager_Master gameManagerMasterScript;
    [SerializeField]
    private string seekerPrefabName;
    [SerializeField]
    private string hiderPrefabName;
    private GameObject[] spawnPoints;
    [SerializeField]
    private string spawnPointTag;

    private int gameRole; //0 for hider, 1 for seeker

	void OnEnable() 
	{
		SetInitialReferences();
        networkingMasterScript.EventSpawnPlayer += SpawnPlayer;
	}

	void OnDisable() 
	{
        networkingMasterScript.EventSpawnPlayer += SpawnPlayer;
    }

	void SetInitialReferences() 
	{
        spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);
        networkingMasterScript = GetComponent<Networking_Master>();
        gameManagerMasterScript = GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameManager_Master>();
	}

    void SpawnPlayer()
    {
        if(gameRole == 1)
        {
            PhotonNetwork.Instantiate(seekerPrefabName, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, spawnPoints[0].transform.rotation, 0);
            Debug.Log("Spawned Seeker");
        }
        else
        {
            PhotonNetwork.Instantiate(hiderPrefabName, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, spawnPoints[0].transform.rotation, 0);
            Debug.Log("Spawned Hider");
        }
        //if(photonView.isMine)
        //{
            gameManagerMasterScript.CallEventDisableMenuCamera();
        //}
    }

    public void ChoiceSeeker()
    {
        gameRole = 1;
        SpawnPlayer();
    }

    public void ChoiceHider()
    {
        gameRole = 0;
        SpawnPlayer();
    }
}
