using UnityEngine;
using System.Collections;

public class GameMech_PlayerGotHit : MonoBehaviour {

    [PunRPC]
    public void GetHit()
    {
        PhotonNetwork.Destroy(gameObject);
    }
}
