using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// The interactable button mechanic (3) of the game
    /// A button that activates/deactivates a set of platforms
    /// </summary>
    public class InteractableButton : MonoBehaviour
    {
        public GameObject lightPlatforms;
        [SerializeField] bool playerClose = false;

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
                    EventsManager.OnButtonPressEvent?.Invoke();
                    Debug.Log("Platform button activated");
                }
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