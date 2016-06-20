using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace main
{
	public class GameManager_LoadGameScene : MonoBehaviour {

        private GameManager_Master gameManagerMaster;

        [SerializeField]
        private int amountOfScenes;

		void OnEnable()
		{
            SetInitialReferences();
            gameManagerMaster.EventLoadGameScene += LoadRandomGameScene;
		}

		void OnDisable()
		{
            gameManagerMaster.EventLoadGameScene -= LoadRandomGameScene;
        }

		void SetInitialReferences()
		{
            gameManagerMaster = GetComponent<GameManager_Master>();
		}

        void LoadRandomGameScene()
        {
            int sceneToLoad;
            sceneToLoad = Random.Range(1, amountOfScenes);

            SceneManager.LoadScene(sceneToLoad);
        } 
	}
}


