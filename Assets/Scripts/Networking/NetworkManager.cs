using UnityEngine;
using System.Collections;

public class NetworkManager : Photon.PunBehaviour {

    private string gameVersion = "0.01";
    public string roomName = "room";

    public string playerPrefabName = "FPSController";
    public GameObject[] spawnPoints;

	void Start()
    {
        Connect();
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    void Connect()
    {
        PhotonNetwork.ConnectUsingSettings(gameVersion);
    }

    void OnGUI()
    {
        //Toont connectie details
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }

    //PUN
    void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom();
        print("OnJoinedLobby");
    }

    //PUN
    void OnPhotonRandomJoinFailed()
    {
        RoomOptions roomOptions = new RoomOptions() { isVisible = true, maxPlayers = 4};
        PhotonNetwork.CreateRoom(null, roomOptions, TypedLobby.Default);
        print("OnPhotonRandomJoinFailed");
    }

    //PUN
    void OnJoinedRoom()
    {
        SpawnPlayer();
        print("OnJoinedRoom");
    }

    void SpawnPlayer()
    {
        PhotonNetwork.Instantiate(playerPrefabName, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, spawnPoints[0].transform.rotation, 0);

    }
}
