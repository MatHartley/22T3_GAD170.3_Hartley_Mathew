using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    public class CubeActivator : MonoBehaviour
    {
        private void Update()
        {
            //If the player presses E...
            if (Input.GetKeyDown(KeyCode.E))
            {
                //announce the EVENT.
                Debug.Log("E has been pressed");
                EventManager.OnTeleportEvent?.Invoke();
                EventManager.OnChangeColourEvent?.Invoke();
            }
        }
    }
}