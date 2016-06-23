using UnityEngine;
using System.Collections;

public class GameMech_PlayerGotHit : MonoBehaviour {

	void OnEnable() 
	{
		SetInitialReferences();
	}

	void OnDisable() 
	{

	}
	
	void Update () 
	{
	
	}

	void SetInitialReferences() 
	{

	}

    [PunRPC]
    public void GetHit()
    {
        Debug.Log("got hit");
    }
}
