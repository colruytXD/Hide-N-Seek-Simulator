using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace main
{
	public class GameManager_LoadGameScene : Photon.MonoBehaviour {

        private GameManager_Master gameManagerMaster;

        [SerializeField]
        private int NextSceneNumber;

		void OnEnable()
		{
            SetInitialReferences();
            gameManagerMaster.EventLoadGameScene += LoadChosenGameScene;
		}

		void OnDisable()
		{
            gameManagerMaster.EventLoadGameScene -= LoadChosenGameScene;
        }

		void SetInitialReferences()
		{
            gameManagerMaster = GetComponent<GameManager_Master>();
		}

        void LoadChosenGameScene()
        {
                SceneManager.LoadScene(NextSceneNumber);
        } 
	}
}


