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
    public class JumpTutorial : MonoBehaviour
    {
        public GameObject jumpPopup;

        /// <summary>
        /// shows the jumping tutorial pop up if the player character enters the trigger
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                jumpPopup.SetActive(true);
                Debug.Log("Jump Trigger Active");
            }
        }

        /// <summary>
        /// removes the jumping tutorial pop up if the player character leaves the trigger
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                jumpPopup.SetActive(false);
                Debug.Log("Jump Trigger Inactive");
            }
        }
    }
}