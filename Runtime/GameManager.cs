using log4net.Util;
using UnityEngine;

namespace Espresso.AppManagement
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] protected MainMenu m_mainMenu;

        public virtual void StartGame()
        {
            Debug.Log("Empty StartGame called.");
        }

        public virtual void LoadGame()
        {
            Debug.Log("Empty LoadGameCalled");
        }
    }
}
