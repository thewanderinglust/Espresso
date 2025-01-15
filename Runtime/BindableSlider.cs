using System;
using UnityEngine;
using UnityEngine.UI;

namespace Espresso.UIUtilities
{
    public class BindableSlider : MonoBehaviour
    {
        [Header("UI Hookups")]
        
        // The slider component of the UI object.
        [SerializeField] private Slider m_sliderComponent;

        [Header("Properties")]

        // Getter for the slider component
        public Slider Slider { get { return m_sliderComponent; } }

        // Function to call to get the value to set the slider.
        private Func<float> GetBoundValue;

        /// <summary>
        /// Calls the assigned function to get the new value for the slider and update the slider value. Will clamp < 0.0 and > 1.0
        /// </summary>
        public void Update()
        {
            float updatedValue = GetBoundValue();

            if (updatedValue > 1.0f)
            {
                updatedValue = 1.0f;
                Debug.LogWarning("Property value clamped to 1.0");
            }
            else if (updatedValue < 0.0f)
            {
                updatedValue = 0.0f;
                Debug.LogWarning("Property value clamped to 0.0");
            }

            m_sliderComponent.value = updatedValue;
        }

        /// <summary>
        /// Set the function that this slider will use to keep its value updated.
        /// </summary>
        /// <param name="a_floatFunction"></param>
        public void BindFunctionForFloatValue(Func<float> a_floatFunction)
        {
            GetBoundValue = a_floatFunction;
        }
    }
}
