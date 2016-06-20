using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class NetworkPlayer : Photon.MonoBehaviour {

    public GameObject myCamera;

	void OnEnable() 
	{
        if(photonView.isMine)
        {
            myCamera.SetActive(true);
            GetComponent<FirstPersonController>().enabled = true;
        }
    }
}
