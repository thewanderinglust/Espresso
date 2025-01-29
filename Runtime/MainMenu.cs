using UnityEngine;

namespace Espresso.UIUtilities
{
    public class MainMenu : MonoBehaviour
    {        
        public void OnStartGame()
        {
             Debug.LogWarning("StartGame not implemented");
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
