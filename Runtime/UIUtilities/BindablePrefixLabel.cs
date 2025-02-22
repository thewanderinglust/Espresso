using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Espresso.UIUtilities
{
    public class BindablePrefixLabel : MonoBehaviour
    {
        [Header("Data Hookups")]
        [SerializeField] private string m_labelString;
        [SerializeField] private bool m_isSuffix = false;

        [Header("UI Hookups")]
        [SerializeField] private TextMeshProUGUI m_textElement;

        // Function to call to get the value to set the slider.
        private Func<string> GetBoundPrefix;

        public void Update()
        {
            if (m_isSuffix)
            {
                m_textElement.text = GetBoundPrefix() + " " + m_labelString;
            }
            else
            {
                m_textElement.text = m_labelString + " " + GetBoundPrefix();
            }
        }

        /// <summary>
        /// Set the function that this lavel will use to keep updated.
        /// </summary>
        /// <param name="a_stringFunction"></param>
        public void BindFunctionForStringValue(Func<string> a_stringFunction)
        {
            GetBoundPrefix = a_stringFunction;
        }
    }
}