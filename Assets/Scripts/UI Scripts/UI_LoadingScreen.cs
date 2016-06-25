using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_LoadingScreen : MonoBehaviour {

    private Text txtLoading;
    [SerializeField]
    private float waitTime = 0.1f;

	void OnEnable() 
	{
		SetInitialReferences();
        ChangeLoadingText();
	}

	void SetInitialReferences() 
	{
        txtLoading = GetComponent<Text>();
	}

    void ChangeLoadingText()
    {
        StartCoroutine(one());
    }

    IEnumerator one()
    {
        txtLoading.text = "Loading.";
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(two());
    }

    IEnumerator two()
    {
        txtLoading.text = "Loading..";
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(tree());
    }

    IEnumerator tree()
    {
        txtLoading.text = "Loading...";
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(one());
    }
}
