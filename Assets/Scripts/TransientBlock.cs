using MathewHartley;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// Controls the transient block (4) mechanic of the game
    /// Uses the event manager system to enable/disable the box colliders of set platform prefabs
    /// Also changes the alpha level of said prefabs to become more "solid" when active
    /// </summary>
    public class TransientBlock : MonoBehaviour
    {
        [SerializeField] bool buttonToggle = true;

        /// <summary>
        /// Subscribes to the event system
        /// </summary>
        private void OnEnable()
        {
            EventsManager.OnButtonPressEvent += ToggleTangible;
        }

        /// <summary>
        /// Unsubscribes from the event system
        /// </summary>
        private void OnDisable()
        {
            EventsManager.OnButtonPressEvent -= ToggleTangible;
        }
        /// <summary>
        /// Activates and deactivates the box collider on light platforms based on buttontoggle boolean
        /// Changes the alpha level of the light platforms to be high if buttontoggle boolen is true
        /// Changes the alpha level of the light platforms to be low if buttontoggle boolen is false
        /// </summary>
        private void ToggleTangible()
        {
            gameObject.GetComponent<BoxCollider>().enabled = (buttonToggle);
            if (buttonToggle == true)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = new Color(0f, 1f, 1f, 0.8f);
            }
            else if (buttonToggle == false)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = new Color(0f, 1f, 1f, 0.2f);
            }
            ButtonSwitch();
        }

        /// <summary>
        /// a boolen switch to allow the button to turn the platforms on if they are off,
        /// or off if they are on
        /// </summary>
        void ButtonSwitch()
        {
            if (buttonToggle == true)
            {
                buttonToggle = false;
                Debug.Log("buttonToggle is false");
            }
            else if (buttonToggle == false)
            {
                buttonToggle = true;
                Debug.Log("buttonToggle is true");
            }
        }
    }
}