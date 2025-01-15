using UnityEngine;

namespace Espresso.CameraUtilities
{
    public class SpringArm : MonoBehaviour
    {
        [SerializeField] private GameObject m_attachedObject;

        private Vector3 m_offsetToMaintain;

        private Vector3 AttachedPosition { get { return m_attachedObject.transform.position; } }
        private Vector3 CurrentOffset { get { return transform.position - m_attachedObject.transform.position; }}

        void Awake()
        {
            if (m_attachedObject != null)
            {
                SetOffset();
            }
        }

        void Update()
        {
            if (m_attachedObject != null)
            {
                MaintainOffset();
            }
        }

        private void SetOffset()
        {
            m_offsetToMaintain = transform.position - AttachedPosition;
        }

        private void MaintainOffset()
        {
            if (CurrentOffset != m_offsetToMaintain)
            {
                Vector3 newArmPosition = AttachedPosition;
                newArmPosition += m_offsetToMaintain;
                transform.position = newArmPosition;
            }
        }
    }
}
