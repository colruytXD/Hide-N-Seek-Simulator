using UnityEngine;
using System.Collections;

public class GameMech_Master : MonoBehaviour {

    public delegate void GameMechHandler();

    public delegate void HitPlayerHandler(Transform transform);

    //public event HitPlayerHandler EventHitPlayer;

    //public void CallEventHitPlayer(Transform transform)
    //{
    //    if(EventHitPlayer != null)
    //    {
    //        EventHitPlayer(transform);
    //    }
    //}
}
