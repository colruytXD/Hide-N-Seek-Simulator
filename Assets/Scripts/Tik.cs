using UnityEngine;
using System.Collections;

public class Tik : MonoBehaviour {

    [PunRPC]
    public void DestroyThis()
    {
        Destroy(this.gameObject);
    }
}
