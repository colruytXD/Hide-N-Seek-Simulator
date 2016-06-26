using UnityEngine;
using System.Collections;

public class GameMech_PlayerGotHit : Photon.MonoBehaviour {

    private GameManager_Master gameManagerMasterScript;


    void OnEnable()
    {
        SetInitalReferences();
    }

    void SetInitalReferences()
    {
        gameManagerMasterScript = GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameManager_Master>();
    }

    [PunRPC]
    public void PlayerGotHit()
    {
        Debug.Log("Awtch i got hit");
        gameManagerMasterScript.CallEventPlayerDied();
        DestroyPlayer();
    }

    void DestroyPlayer()
    {
        if(photonView.isMine)
        {
            PhotonNetwork.Destroy(gameObject);
        }
    }
}
