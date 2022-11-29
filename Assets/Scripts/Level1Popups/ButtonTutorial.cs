using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// The popup tutorial mechanic of the game
    /// This iteration of the mechanic has each trigger with a separate, almost identicle script
    /// It is functional, but not as streamlined as I would like
    /// The popup manager is not functional if this is active
    /// </summary>
    public class ButtonTutorial : MonoBehaviour
    {
        public GameObject buttonPopup;

        /// <summary>
        /// shows the button tutorial pop up if the player character enters the trigger
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                buttonPopup.SetActive(true);
                Debug.Log("Button Trigger Active");
            }
        }

        /// <summary>
        /// removes the button tutorial pop up if the player character leaves the trigger
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                buttonPopup.SetActive(false);
                Debug.Log("Button Trigger Inactive");
            }
        }
    }
}