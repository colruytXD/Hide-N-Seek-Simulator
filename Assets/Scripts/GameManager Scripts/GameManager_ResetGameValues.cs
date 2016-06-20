using UnityEngine;
using System.Collections;

namespace main
{
	public class GameManager_ResetGameValues : MonoBehaviour {

        private GameManager_Master gameManagerMaster;

        [Tooltip("All saved things that need to be deleted")]
        public string[] values;

		void OnEnable()
		{
            SetInitialReferences();
            gameManagerMaster.EventResetGameValues += ResetGameValues;
		}

		void OnDisable()
		{
            gameManagerMaster.EventResetGameValues -= ResetGameValues;
        }

		void SetInitialReferences()
		{
            gameManagerMaster = GetComponent<GameManager_Master>();
		}

        void ResetGameValues()
        {
            for(int i = 0; i < values.Length; i++)
            {
                PlayerPrefs.DeleteKey(values[i]);
            }
        }
	}
}


