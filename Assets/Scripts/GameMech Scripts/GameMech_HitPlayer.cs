using UnityEngine;
using System.Collections;

public class GameMech_HitPlayer : MonoBehaviour {

    private GameMech_Master gameMechMasterScript;
    private RaycastHit hit;
    [SerializeField]
    private float hitRange = 5;
    [SerializeField]
    private LayerMask playerLayer;

	void Update () 
	{
        CheckForPlayer();
	}

    void CheckForPlayer()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("mouse0 pressed");
            Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward, Color.blue, 10f);
            if(Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, hitRange, playerLayer))
            {
                Debug.Log("hit " + hit.transform.name);
                if(GetComponent<GameMech_PlayerGotHit>() != null)
                {
                    Debug.Log("Called hit");
                    int HittedPhotonID = hit.transform.GetComponent<PhotonView>().GetInstanceID(); 
                    hit.transform.GetComponent<PhotonView>().RPC("PlayerGotHit", PhotonTargets.Others);
                }
                else
                {
                    Debug.LogError("Player has no PlayerGotHit script, attach one!");
                }
            }
        }
    }
}
