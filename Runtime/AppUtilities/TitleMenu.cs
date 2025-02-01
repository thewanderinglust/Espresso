using UnityEngine;

namespace Espresso.AppUtilities
{
    /// <summary>
    /// Provides logic for a simple title menu that can only move forward to a main menu.
    /// Most commonly would appear to a play as the title screen stating "press start to play"
    /// </summary>
    public class TitleMenu : MonoBehaviour
    {
        /// <summary>
        /// The Espresso MainMenu that should be activated once the player continues from this title menu.
        /// </summary>
        [SerializeField] private MainMenu m_mainMenu;

        /// <summary>
        /// Expecting to be called by a button class or an input action. 
        /// </summary>
        public void OnContinue()
        {
            m_mainMenu.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
