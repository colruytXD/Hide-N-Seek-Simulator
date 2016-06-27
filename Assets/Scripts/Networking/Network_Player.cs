using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Network_Player : Photon.MonoBehaviour {

    public GameObject myCamera;
    public FirstPersonController FPSC;
    private int syncSpeed = 20;


    private Vector3 correctPlayerPos = Vector3.zero; // We lerp towards this
    private Quaternion correctPlayerRot = Quaternion.identity; // We lerp towards this

    void Start()
    {
        if (photonView.isMine)
        {
            myCamera.SetActive(true);
            FPSC.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!photonView.isMine)
        {
            transform.position = Vector3.Lerp(transform.position, this.correctPlayerPos, Time.deltaTime * syncSpeed);
            transform.rotation = Quaternion.Lerp(transform.rotation, this.correctPlayerRot, Time.deltaTime * syncSpeed);
        }
        

    }

    void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        {
            // We own this player: send the others our data
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
        }
        else
        {
            // Network player, receive data
            this.correctPlayerPos = (Vector3)stream.ReceiveNext();
            this.correctPlayerRot = (Quaternion)stream.ReceiveNext();
        }
    }
}
