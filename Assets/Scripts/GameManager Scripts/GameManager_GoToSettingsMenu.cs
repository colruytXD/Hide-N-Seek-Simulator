using UnityEngine;
using System.Collections;

namespace main
{
	public class GameManager_GoToSettingsMenu : MonoBehaviour {

        private GameManager_Master gameManagerMaster;

        [SerializeField]
        private GameObject mainMenuUI;
        [SerializeField]
        private GameObject settingsMenuUI;

		void OnEnable()
		{
            SetInitialReferences();
            gameManagerMaster.EventGoToSettingsMenu += EnableSettingsMenu;
		}

		void OnDisable()
		{
            gameManagerMaster.EventGoToSettingsMenu -= EnableSettingsMenu;
		}

		void SetInitialReferences()
		{
            gameManagerMaster = GetComponent<GameManager_Master>();
		}

        void EnableSettingsMenu()
        {
            mainMenuUI.SetActive(false);
            settingsMenuUI.SetActive(true);
        }
	}
}


