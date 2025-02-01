using System;
using System.Collections.Generic;
using PlasticPipe.PlasticProtocol.Messages;
using UnityEngine;

namespace Espresso.AppUtilities
{
    /// <summary>
    /// Provides simple logic for keeping storing, accessing, and switching between game modes.
    /// Represents a unifying core for managing game flow.
    /// </summary>
    public abstract class AbstractGameManager : MonoBehaviour
    {
        /// <summary>
        /// Called when main menu "Start New Game" button is pressed.
        /// </summary>
        /// <param name="a_mainMenu">The main menu calling this function.</param>
        public abstract void OnStartNewGame(MainMenu a_mainMenu);

        /// <summary>
        /// Called when main menu "Load Game" button is pressed.
        /// <param name="a_mainMenu">The main menu calling this function.</param>
        public abstract void OnLoadGame(MainMenu a_mainMenu);

        /// <summary>
        /// List of game mode objects that the game manager should track
        /// </summary>
        [SerializeField] private List<AbstractMode> m_listModes;

        /// <summary>
        /// Dictionary used to accessing game modes based on their mode ID.
        /// The default implementation of AbstractGameManager will initialize this dict using listModes on Awake()
        /// </summary>
        protected Dictionary<ModeID, AbstractMode> m_dictModes;

        /// <summary>
        /// Property that returns all mode gameobjects.
        /// </summary>
        protected List<GameObject> ListModeObjects
        {
            get
            {
                List<GameObject> objList = new List<GameObject>();
                foreach (var mode in m_listModes)
                {
                    objList.Add(mode.gameObject);
                }
                return objList;
            }
        }

        /// <summary>
        /// Given a mode id, returns a reference to that mode object if it can be found. Otherwise, returns null.
        /// </summary>
        /// <param name="a_id">The ID of the mode to return.</param>
        /// <returns>A mode of the given ID if found; otherwise returns null.</returns>
        public AbstractMode GetModeByID(ModeID a_id)
        {
            if (m_dictModes.ContainsKey(a_id))
            {
                return m_dictModes[a_id];
            }
            else
            {
                Debug.LogWarning("Mode " + a_id.name + " not found.");
                return null;
            }
        }

        /// <summary>
        /// Default implementation of Awake initializes the mode dictionary and provides a reference to this manager instance to each given mode.
        /// </summary>
        protected virtual void Awake()
        {
            InitmodeDictionary();
            InjectManagerReferenceToModes();
        }

        /// <summary>
        /// Initialize the dictionary of game modes. The data structure is still initialized even if no modes are found in the list.
        /// </summary>
        protected void InitmodeDictionary()
        {
            m_dictModes = new Dictionary<ModeID, AbstractMode>();

            if (m_listModes.Count == 0)
            {
                Debug.LogWarning("No modes assigned to game manager by default.");
            }
            else
            {
                foreach(AbstractMode mode in m_listModes)
                {
                    m_dictModes.Add(mode.ID, mode);
                    Debug.Log(mode.ID.name + " mode registered with game manager.");
                }
            }
        }

        /// <summary>
        /// Provides a references to this game manager object to each supplied game mode.
        /// </summary>
        protected void InjectManagerReferenceToModes()
        {
            foreach(AbstractMode mode in m_listModes)
            {
                mode.SetGameManager(this);
            }
        }

        protected void DisableAllGameModeObjects()
        {
            foreach (GameObject gameObject in ListModeObjects)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
