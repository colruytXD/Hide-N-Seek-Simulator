using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace main
{
	public class Settings_SetControls : MonoBehaviour {

        private Settings_Master settingsMaster;
        private GameManager_Master gameManagerMaster;

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
            gameManagerMaster.EventGoToMainMenu += SetControls;
            settingsMaster.EventSetSavedSettings += SetControls;
		}

		void OnDisable()
		{
            gameManagerMaster.EventGoToMainMenu -= SetControls;
            settingsMaster.EventSetSavedSettings -= SetControls;
        }

		void SetInitialReferences()
		{
            settingsMaster = GetComponent<Settings_Master>();
            gameManagerMaster = GetComponent<GameManager_Master>();
		}

        void SetControls()
        {
            if(PlayerPrefs.HasKey("forward"))
            {
                Debug.Log("Saving controls");
                PlayerPrefs.SetString("forward", forwardText.text);
                PlayerPrefs.SetString("backward", backwardText.text);
                PlayerPrefs.SetString("left", leftText.text);
                PlayerPrefs.SetString("right", rightText.text);
            }
            else
            {
                Debug.Log("Setting controls to defaults");
                PlayerPrefs.SetString("forward", "z");
                PlayerPrefs.SetString("backward", "s");
                PlayerPrefs.SetString("left", "q");
                PlayerPrefs.SetString("right", "d");
            }
        }
	}
}


