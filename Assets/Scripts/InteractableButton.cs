using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// The interactable button and transient block mechanic of the game
    /// A button that activates/deactivates a set of platforms
    /// It is scripted so that any given button has a single set of platforms connected to it
    /// </summary>
    public class InteractableButton : MonoBehaviour
    {
        public GameObject lightPlatforms;
        [SerializeField] bool playerClose = false;
        [SerializeField] bool buttonToggle = true;

        /// <summary>
        /// checks if the player character is close to the button
        /// if they are, they can activate the button with E to activate/deactivate
        /// the platforms
        /// </summary>
        void Update()
        {
            if (playerClose == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    lightPlatforms.SetActive(buttonToggle);
                    Debug.Log("Platform button activated");
                    ButtonSwitch();
                }
            }
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
           else  if (buttonToggle == false)
            {
                buttonToggle = true;
                Debug.Log("buttonToggle is true");
            }
        }

        /// <summary>
        /// activates a boolean for when the player enters the button area, allowing the button
        /// to be hit
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                playerClose = true;
            }
        }
        /// <summary>
        /// deactivates a boolean for when the player enters the button area, stopping the button
        /// to be hit
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                playerClose = false;
            }
        }
    }
}