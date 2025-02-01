using UnityEngine;

namespace Espresso.AppUtilities
{
    /// <summary>
    /// Provides logic for a simple main menu with basic functions universal to most games.
    /// Expects external input such as buttons on input actions to call its functions.
    /// </summary>
    public class MainMenu : MonoBehaviour
    {        
        /// <summary>
        /// Reference to the game manager object. It must implement interface IGameManager.
        /// </summary>
        [SerializeField] private AbstractGameManager m_gameManager;

        /// <summary>
        /// Expecting to be called by a button class or an input action.
        /// </summary>
        public virtual void OnStartGame()
        {
            m_gameManager.OnStartNewGame(this);
        }

        /// <summary>
        /// Expecting to be called by a button class or an input action.
        /// </summary>
        public virtual void OnLoadGame()
        {
            m_gameManager.OnStartNewGame(this);
        }

        /// <summary>
        /// Expecting to be called by a button class or an input action.
        /// </summary>
        public virtual void OnQuit()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #elif UNITY_WEBPLAYER
            Appliccation.OpenURL(webplayerQuitURL);
            #else
            Appliccation.Quit();
            #endif
        }

        /// <summary>
        /// Expecting to be called by a button class or an input action.
        /// </summary>
        public virtual void OnOptions()
        {
            Debug.LogWarning("Options not implemented");
        }
    }
}
