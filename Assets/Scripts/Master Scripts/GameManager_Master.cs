using UnityEngine;
using System.Collections;

    public class GameManager_Master : MonoBehaviour
    {
        public delegate void GameManagerHandler();

        public event GameManagerHandler EventQuitGame;
        public event GameManagerHandler EventGoToSettingsMenu;
        public event GameManagerHandler EventTogglePauseMenu;
        public event GameManagerHandler EventGoToMainMenu;
        public event GameManagerHandler EventResetGameValues;
        public event GameManagerHandler EventLoadGameScene;
        public event GameManagerHandler EventGoToMPMenu;
        public event GameManagerHandler EventPlayerDied;

        public void CallEventQuitGame()
        {
            if (EventQuitGame != null)
            {
                EventQuitGame();
            }
        }

        public void CallEventGoToSettingsMenu()
        {
            if (EventGoToSettingsMenu != null)
            {
                EventGoToSettingsMenu();
            }
        }

        public void CallEventTogglePauseMenu()
        {
            if (EventTogglePauseMenu != null)
            {
                EventTogglePauseMenu();
            }
        }

        public void CallEventGoToMainMenu()
        {
            if(EventGoToMainMenu != null)
            {
                EventGoToMainMenu();
            }
        }

        public void CallEventResetGameValues()
        {
            if(EventResetGameValues != null)
            {
                EventResetGameValues();
            }
        }

        public void CallEventLoadGameScene()
        {
            if(EventLoadGameScene != null)
            {
                EventLoadGameScene();
            }
        }

        public void CallEventGoToMPMenu()
        {
            if(EventGoToMPMenu != null)
            {
                EventGoToMPMenu();
            }
        }

        public void CallEventPlayerDied()
        {
            if(EventPlayerDied != null)
            {
                EventPlayerDied();
            }
        }
    }


