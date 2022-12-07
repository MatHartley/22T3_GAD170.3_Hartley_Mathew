using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    public class Teleporter : MonoBehaviour
    {
        // This cube will teleport when the "OnTeleportEvent" event is announced
        // Teleport will move the cube to a random position on the Y axis
        private void OnEnable()
        {
            EventManager.OnTeleportEvent += Teleport;
        }

        private void OnDisable()
        {
            EventManager.OnTeleportEvent -= Teleport;
        }
        private void Teleport()
        {
            transform.position = new Vector3(2, Random.Range(0.5f, 4f), 0);
        }
    }
}