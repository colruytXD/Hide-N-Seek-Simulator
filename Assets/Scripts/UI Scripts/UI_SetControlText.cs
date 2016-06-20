using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace main
{
	public class UI_SetControlText : MonoBehaviour {

        private Settings_Master settingsMaster;

        [SerializeField]
        private InputField forwardText;
        [SerializeField]
        private InputField backwardText;
        [SerializeField]
        private InputField leftText;
        [SerializeField]
        private InputField rightText;

		void OnEnable()
		{
            SetInitialReferences();
            SetTexts();
		}

		void SetInitialReferences()
		{
            settingsMaster = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Settings_Master>();
		}

        void SetTexts()
        { 
            settingsMaster.CallEventGetSavedSettings();
            Debug.Log("Setting texts");
            forwardText.text = settingsMaster.forwardControl;
            backwardText.text = settingsMaster.backwardControl;
            leftText.text = settingsMaster.leftControl;
            rightText.text = settingsMaster.rightControl;
        }
	}
}


