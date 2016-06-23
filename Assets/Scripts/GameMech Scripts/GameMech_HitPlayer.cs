using UnityEngine;
using System.Collections;

public class GameMech_HitPlayer : MonoBehaviour {

    private GameMech_Master gameMechMasterScript;

	void OnEnable() 
	{
		SetInitialReferences();
	}

	void OnDisable() 
	{

	}
	
	void Update () 
	{
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            DestroyThis();
        }
	}

	void SetInitialReferences() 
	{
        gameMechMasterScript = GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameMech_Master>();
	}

    [PunRPC]
    public void DestroyThis()
    {
        PhotonNetwork.Destroy(GetComponent<PhotonView>());
    }
}
