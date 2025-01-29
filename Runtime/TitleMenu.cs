using UnityEngine;

namespace Espresso.UIUtilities
{
    public class TitleMenu : MonoBehaviour
    {
        [SerializeField] private MainMenu m_mainMenu;

        public void OnContinue()
        {
            m_mainMenu.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
