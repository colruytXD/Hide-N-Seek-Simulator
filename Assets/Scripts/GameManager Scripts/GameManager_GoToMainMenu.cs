using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace main
{
	public class GameManager_GoToMainMenu : MonoBehaviour {

        private GameManager_Master gameManagerMaster;

        [SerializeField]
        private GameObject panelSettingsUI, panelPauseUI, panelMainMenuUI;

		void Start () 
		{
	
		}
	
		void Update () 
		{
	
		}

		void OnEnable()
		{
            SetInitialReferences();
            gameManagerMaster.EventGoToMainMenu += GoToMainMenu;
		}

		void OnDisable()
		{
            gameManagerMaster.EventGoToMainMenu -= GoToMainMenu;
        }

		void SetInitialReferences()
		{
            gameManagerMaster = GetComponent<GameManager_Master>();
		}

        void GoToMainMenu()
        {
            SceneManager.LoadScene(0);
        }
	}
}


