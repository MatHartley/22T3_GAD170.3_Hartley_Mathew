using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MathewHartley
{
    /// <summary>
    /// The scene management class of the game. Controls the functionality of a button that
    /// allows the player to load levels, restart the game, or quit.
    /// </summary>
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] bool sceneClose = false;
        public GameObject menuPopup;

        /// <summary>
        /// activates a boolean for when the player enters the button area, allowing the button
        /// to be hit
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                sceneClose = true;
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
                sceneClose = false;
            }
        }

        /// <summary>
        /// checks if the player character is close to the button
        /// if they are, they can activate the button with E to activate/deactivate
        /// the platforms
        /// </summary>
        void Update()
        {
            if (sceneClose == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    menuPopup.SetActive(true);
                    Debug.Log("Special button activated");
                }
            }
        }

        /// <summary>
        /// Loads level 1 - called by a button in the menu
        /// </summary>
        public void Level1Load()
        {
            SceneManager.LoadScene("LevelOne");
        }
        
        /// <summary>
        /// Loads level 2 - called by a button in the menu
        /// </summary>
        public void Level2Load()
        {
            SceneManager.LoadScene("LevelTwo");
        }

        /// <summary>
        /// Quits the game - called by a buttomn in the menu
        /// </summary>
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}