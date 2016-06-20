using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

    private string gameVersion = "0.01";
    public string roomName = "room";

    public string playerPrefabName = "FPSController";
    public Transform spawnPoint;

	void OnEnable() 
	{
		SetInitialReferences();

        PhotonNetwork.ConnectUsingSettings(gameVersion);
	}

	void OnDisable() 
	{

	}

	void SetInitialReferences() 
	{

	}

    void OnJoinedLobby()
    {
        RoomOptions roomOptions = new RoomOptions() { isVisible = false, maxPlayers = 4 };
        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(playerPrefabName, spawnPoint.position, spawnPoint.rotation, 0);
    }
}
