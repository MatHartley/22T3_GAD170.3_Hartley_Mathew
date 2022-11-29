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
    public class NPCPopup : MonoBehaviour
    {
        public GameObject missingPopup;
        public GameObject foundPopup;
        //public script itemGet;
        

        /// <summary>
        /// shows the NPC's pop up if the player character enters the trigger
        /// </summary>
        /// <param name="other"></param>
        //private void OnTriggerEnter(Collider other)
        //{
        //    if (other.tag == "PlayerCharacter")
        //    {
        //        Debug.Log("NPC Trigger Active");
        //        if (itemGet.itemCollect == true)
        //        {
        //            foundPopup.SetActive(true);
        //        }
        //        else
        //        {
        //            missingPopup.SetActive(true);
        //        }
        //    }
        //}

        /// <summary>
        /// removes the NPC's pop up if the player character leaves the trigger
        /// </summary>
        /// <param name="other"></param>
        //private void OnTriggerExit(Collider other)
        //{
        //    if (other.tag == "PlayerCharacter")
        //    {
        //        Debug.Log("NPC Trigger Inactive");
        //        if (itemGet.itemCollect == true)
        //        {
        //            foundPopup.SetActive(true);
        //        }
        //        else
        //        {
        //            missingPopup.SetActive(true);
        //        }
        //    }
        //}
    }
}