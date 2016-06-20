using UnityEngine;
using System.Collections;

namespace main
{
	public class GameManager_QuitGame : MonoBehaviour {

        private GameManager_Master gameManagerMaster;

		void OnEnable()
		{
            SetInitialReferences();
            gameManagerMaster.EventQuitGame += Quit;
		}

		void OnDisable()
		{
            gameManagerMaster.EventQuitGame -= Quit;
        }

		void SetInitialReferences()
		{
            gameManagerMaster = GetComponent<GameManager_Master>();
		}
        public void Quit()
        {
            Application.Quit();
        }
    }
}


