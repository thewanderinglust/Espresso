using System;
using UnityEngine;

namespace Espresso.DataUtilities
{
    [Serializable]
    public class TierThreshhold
    {
        [SerializeField]
        public float m_value;
        [SerializeField]
        public int m_tier;
    }
}
