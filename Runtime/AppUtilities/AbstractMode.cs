using Espresso.AppUtilities;
using UnityEngine;

public abstract class AbstractMode : MonoBehaviour
{
    [Tooltip("The ModeID for this mode object.")]
    [SerializeField] private ModeID m_ID;

    public ModeID ID {get { return m_ID; } }
    protected AbstractGameManager m_gameManager;

    public void SetGameManager(AbstractGameManager a_manager)
    {
        if (m_gameManager == null)
        {
            m_gameManager = a_manager;
        }
    }
}
