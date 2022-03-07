using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        #region Public Variables

        public GameStates gameState = GameStates.MainMenu;

        #endregion

        #region Private Variables



        #endregion

        void ChangeState(GameStates newGameState)
        {
            switch(newGameState)
            {
                case GameStates.MainMenu:
                    break;
                case GameStates.Game:
                    break;
                case GameStates.CameraRail:
                    break;
                case GameStates.Viewing:
                    break;
            }
        }
    }
}

public enum GameStates
{
    MainMenu,
    Game,
    CameraRail,
    Viewing,
}

