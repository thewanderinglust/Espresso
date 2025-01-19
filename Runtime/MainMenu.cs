using UnityEngine;

namespace Espresso.AppManagement
{
    
    public class MainMenu : MonoBehaviour
    {        
        [SerializeField] private GameManager m_gameManager;

        public void OnStartGame()
        {
             m_gameManager.StartGame();
        }

        public void OnQuit()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #elif UNITY_WEBPLAYER
            Appliccation.OpenURL(webplayerQuitURL);
            #else
            Appliccation.Quit();
            #endif
        }

        public void OnOptions()
        {
            Debug.LogWarning("Options not implemented");
        }
    }
}
