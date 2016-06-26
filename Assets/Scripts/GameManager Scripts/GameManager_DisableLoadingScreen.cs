using UnityEngine;
using System.Collections;

public class GameManager_DisableLoadingScreen : Photon.MonoBehaviour {

    [SerializeField]
    private GameObject loadingCamera;

    private Networking_Master networkMasterScript;

    void OnEnable()
    {
        SetInitialReferences();
        networkMasterScript.EventSpawnPlayer += DisableLoadingCamera;
    }

    void OnDisable()
    {
        networkMasterScript.EventSpawnPlayer -= DisableLoadingCamera;
    }

    void SetInitialReferences()
    {
        networkMasterScript = GameObject.FindGameObjectWithTag("NetworkHandler").GetComponent<Networking_Master>();
    }

    void DisableLoadingCamera()
    {
        loadingCamera.SetActive(false);
    }
}
