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
    public class MoveTutorial : MonoBehaviour
    {
        public GameObject movePopup;

        /// <summary>
        /// shows the movement tutorial pop up if the player character enters the trigger
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                movePopup.SetActive(true);
                Debug.Log("Move Trigger Active");
            }
        }

        /// <summary>
        /// removes the movement tutorial pop up if the player character leaves the trigger
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                movePopup.SetActive(false);
                Debug.Log("Move Trigger Inactive");
            }
        }
    }
}