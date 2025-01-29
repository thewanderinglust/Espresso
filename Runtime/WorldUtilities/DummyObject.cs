using UnityEngine;

namespace Espresso.WorldUtilities
{
    public class DummyObject : MonoBehaviour
    {
        [Tooltip("If enabled, this object will destroy itself on Awake.")]
        [SerializeField] private bool m_editorOnly = true;

        void OnEnable()
        {
            if (m_editorOnly)
            {
                Destroy(gameObject);
            }
        }
    }
}
