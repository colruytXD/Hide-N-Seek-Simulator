using UnityEngine;
using System.Collections;

public class NetworkManager : Photon.PunBehaviour {

    private Networking_Master networkingMasterScript;

    void OnEnable()
    {
        SetInitialReferences();
    }

	void Start()
    {
        Connect();
    }
    

    void SetInitialReferences()
    {
        networkingMasterScript = GetComponent<Networking_Master>();
    }

    void Connect()
    {
        if(networkingMasterScript.offlineMode)
        {
            PhotonNetwork.offlineMode = true;
            OnJoinedLobby();
        }
        else
        {
            PhotonNetwork.ConnectUsingSettings(networkingMasterScript.GAMEVERSION);
        }
    }

    void OnGUI()
    {
        //Toont connectie details
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }

    //PUN
    //Triggers when player comes into the lobby
    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Joined the lobby");
    }

    //PUN
    //Triggers when joining a room has failed
    void OnPhotonRandomJoinFailed()
    {
        RoomOptions roomOptions = new RoomOptions() { isVisible = true, maxPlayers = 4};
        PhotonNetwork.CreateRoom(null, roomOptions, TypedLobby.Default);
        Debug.Log("Joining random room has failed");
    }

    //PUN
    //Triggers when player entered a room
    public override void OnJoinedRoom()
    {
        networkingMasterScript.CallEventSpawnPlayer();
        Debug.Log("Successfully joined a room");
    }
}
