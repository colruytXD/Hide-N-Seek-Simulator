using UnityEngine;
using System.Collections;

public class Network_Disconnect : Photon.MonoBehaviour {

    private Networking_Master networkingMasterScript;

	void OnEnable() 
	{
		SetInitialReferences();
        networkingMasterScript.EventDisconnect += Disconnect;
	}

	void OnDisable() 
	{
        networkingMasterScript.EventDisconnect -= Disconnect;
    }

	void SetInitialReferences() 
	{
        networkingMasterScript = GetComponent<Networking_Master>();
	}

    void Disconnect()
    {       
            PhotonNetwork.Disconnect();        
    }
}
