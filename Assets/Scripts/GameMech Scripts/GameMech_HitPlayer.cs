using UnityEngine;
using System.Collections;

public class GameMech_HitPlayer : MonoBehaviour {

    private GameMech_Master gameMechMasterScript;
    private RaycastHit hit;
    [SerializeField]
    private float hitRange = 5;

	void OnEnable() 
	{
		SetInitialReferences();
	}

	void OnDisable() 
	{

	}
	
	void Update () 
	{
        CheckForPlayer();
	}

	void SetInitialReferences() 
	{
	}

    void CheckForPlayer()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("mouse0 pressed");
            Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward, Color.blue, 10f);
            if(Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, hitRange, LayerMask.NameToLayer("Player")))
            {
                Debug.Log("hit " + hit.transform.name);
                hit.transform.GetComponent<PhotonView>().RPC("GetHit", PhotonTargets.All);
            }
        }
    }
}
