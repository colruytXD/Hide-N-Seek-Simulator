using UnityEngine;
using System.Collections;

public class Network_DisableOwnBody : Photon.MonoBehaviour
{
    public GameObject myVisuals;

    void OnEnable()
    {
        if (photonView.isMine)
        {
            myVisuals.SetActive(false);
        }
    }
}
