using UnityEngine;
using System.Collections;

namespace main
{
    public class Settings_Master : MonoBehaviour
    {

        //Controls
        [HideInInspector]
        public string forwardControl;
        [HideInInspector]
        public string backwardControl;
        [HideInInspector]
        public string leftControl;
        [HideInInspector]
        public string rightControl;

        public delegate void SettingsHandler();

        public event SettingsHandler EventGetSavedSettings;
        public event SettingsHandler EventSetSavedSettings;

        public void CallEventGetSavedSettings()
        {
            if (EventGetSavedSettings != null)
            {
                EventGetSavedSettings();
            }
        }

        public void CallEventSetSavedSettings()
        {
            if(EventSetSavedSettings != null)
            {
                EventSetSavedSettings();
            }
        }
    }
}


