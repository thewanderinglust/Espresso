using System;
using UnityEngine;

namespace Espresso.DataUtilities
{
    [Serializable]
    public class ColorThreshold
    {
        [SerializeField]
        public float m_value;
        [SerializeField]
        public Color m_color;
    }
}
