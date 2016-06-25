using UnityEngine;
using System.Collections;

public class GameManager_DisableLoadingScreen : Photon.MonoBehaviour {

    [SerializeField]
    private GameObject loadingCamera;

    void OnEnable()
    {
        SetInitialReferences();
    }

    void Start()
    {
        if(photonView.isMine)
        {
            DisableLoadingCamera();
        }
    }

    void SetInitialReferences()
    {
        loadingCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void DisableLoadingCamera()
    {
        loadingCamera.SetActive(false);
    }
}
