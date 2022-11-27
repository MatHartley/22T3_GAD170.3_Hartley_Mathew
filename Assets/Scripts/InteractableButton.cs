using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    public class InteractableButton : MonoBehaviour
    {
        public GameObject lightPlatforms;
        public bool playerClose = false;

        /// <summary>
        /// 
        /// </summary>
        void Update()
        {
            if (playerClose == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    lightPlatforms.SetActive(true);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                playerClose = true;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "PlayerCharacter")
            {
                playerClose = false;
            }
        }
    }
}