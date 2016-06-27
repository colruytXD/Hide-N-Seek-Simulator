using UnityEngine;
using System.Collections;

public class Networking_Master : MonoBehaviour {

    //Makes the server local
    public bool offlineMode = false;
    public string GAMEVERSION;

    public delegate void NetworkingHandler();

    public event NetworkingHandler EventSpawnPlayer;
    public event NetworkingHandler EventDisconnect;

    public void CallEventSpawnPlayer()
    {
        if (EventSpawnPlayer != null)
        {
            EventSpawnPlayer();
        }
    }

    public void CallEventDisconnect()
    {
        if(EventDisconnect != null)
        {
            EventDisconnect();
        }
    }
}
