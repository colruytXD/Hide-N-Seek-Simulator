using UnityEngine;
using System.Collections;

public class Network_SpawnPlayer : MonoBehaviour {

    private Networking_Master networkingMasterScript;
    [SerializeField]
    private string playerPrefabName;
    private GameObject[] spawnPoints;
    //TODO: change to tag selector
    [SerializeField]
    private string spawnPointTag;

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
	}

    void SpawnPlayer()
    {
        PhotonNetwork.Instantiate(playerPrefabName, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, spawnPoints[0].transform.rotation, 0);
    }
}
