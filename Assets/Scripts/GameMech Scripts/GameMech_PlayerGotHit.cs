using UnityEngine;
using System.Collections;

public class GameMech_PlayerGotHit : Photon.MonoBehaviour {

    private GameManager_Master gameManagerMasterScript;
    private Networking_Master networkingMasterScript;

    void OnEnable()
    {
        SetInitalReferences();
    }

    void SetInitalReferences()
    {
        gameManagerMasterScript = GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameManager_Master>();
        networkingMasterScript = GameObject.FindGameObjectWithTag("NetworkHandler").GetComponent<Networking_Master>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            PlayerGotHit();
        }
    }

    [PunRPC]
    public void PlayerGotHit()
    {
        Debug.Log(gameObject.name + " got hit");

        if(photonView.isMine)
        {
            gameManagerMasterScript.CallEventPlayerDied();
            networkingMasterScript.CallEventDisconnect();
            gameManagerMasterScript.CallEventLoadGameScene();
        }  
    }
}
