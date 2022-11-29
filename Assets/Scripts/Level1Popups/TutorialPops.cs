using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// The popup tutorial mechanic of the game
    /// This is intended to be a manager class to control all pop up messages during gameplay
    /// It currently does not work in this form
    /// The currently implemented system of individual scripts for each trigger is working
    /// But this is a more elegant solution if I can get it to work
    /// </summary>
    public class TutorialPops : MonoBehaviour
    {
        public GameObject popupTrigger;
        public GameObject movePopup;
        public GameObject jumpPopup;
        public GameObject fallPopup;
        public GameObject buttonPopup;
        public GameObject endPopup;

        /// <summary>
        /// determines which popup trigger has been hit, then displays the pop up panel for
        /// that trigger
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            //no errors in compiling, but not working
            //assuming there is a parent/child issue and that the .name aspect
            //this should work if i can work that out
            if (other.tag == "PlayerCharacter")
            {
                switch (popupTrigger.name)
                {
                    case "MoveTrigger":
                        movePopup.SetActive(true);
                        break;
                    case "JumpTrigger":
                        jumpPopup.SetActive(true);
                        break;
                    case "FallTrigger":
                        fallPopup.SetActive(true);
                        break;
                    case "ButtonTrigger":
                        buttonPopup.SetActive(true);
                        break;
                    case "EndTrigger":
                        endPopup.SetActive(true);
                        break;
                }
            }
        }
        /// <summary>
        /// reverses the OnTriggerEnter method to deactivate a given pop up
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerExit(Collider other)
        {
            //no errors in compiling, but not working
            //assuming there is a parent/child issue and that the .name aspect
            //this should work if i can work that out
            if (other.tag == "PlayerCharacter")
            {
                switch (popupTrigger.name)
                {
                    case "MoveTrigger":
                        movePopup.SetActive(false);
                        break;
                    case "JumpTrigger":
                        jumpPopup.SetActive(false);
                        break;
                    case "FallTrigger":
                        fallPopup.SetActive(false);
                        break;
                    case "ButtonTrigger":
                        buttonPopup.SetActive(false);
                        break;
                    case "EndTrigger":
                        endPopup.SetActive(false);
                        break;
                }
            }
        }
    }
}