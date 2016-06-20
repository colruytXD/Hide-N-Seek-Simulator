using UnityEngine;
using System.Collections;

namespace main
{
	public class Settings_GetControls : MonoBehaviour {

        private Settings_Master settingsMaster;

        void OnEnable()
		{
            SetInitialReferences();
            settingsMaster.EventGetSavedSettings += GetControlsFromSaveFile;
		}

		void OnDisable()
		{
            settingsMaster.EventGetSavedSettings -= GetControlsFromSaveFile;
        }

		void SetInitialReferences()
		{
            settingsMaster = GetComponent<Settings_Master>();
		}

        void GetControlsFromSaveFile()
        {
            if(PlayerPrefs.HasKey("forward"))
            {
                Debug.Log("Getting controls");
                settingsMaster.forwardControl = PlayerPrefs.GetString("forward");
                settingsMaster.backwardControl = PlayerPrefs.GetString("backward");
                settingsMaster.leftControl = PlayerPrefs.GetString("left");
                settingsMaster.rightControl = PlayerPrefs.GetString("right");
            }
            else
            {
                Debug.Log("Calling setsaved event");
                settingsMaster.CallEventSetSavedSettings();
            }
        }
	}
}


