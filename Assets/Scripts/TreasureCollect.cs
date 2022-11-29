using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// A collectable aspect for the game
    /// This allows the player character to collect the item, removing it from the map
    /// Changes the player character model to show the item
    /// If the player character returns to NPC with the item, the NPC model changes to show the item
    /// And the player character model changes back to normal
    /// </summary>
    public class TreasureCollect : MonoBehaviour
    {
        [SerializeField] private bool treasureClose = false;
        public bool itemCollect = false;

        /// <summary>
        /// activates a boolean for when the player enters the button area, allowing the button
        /// to be hit
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                treasureClose = true;
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
                treasureClose = false;
            }
        }
        /// <summary>
        /// checks if the player character is close to the button
        /// if they are, they can press E to collect the treasured item
        /// this will remove the item from the level, and change the character model to
        /// display it
        /// </summary>
        void Update()
        {
            if (treasureClose == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    itemCollect = true;
                }
            }
        }
    }
}