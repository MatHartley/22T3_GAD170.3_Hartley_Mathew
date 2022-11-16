using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    public class DoomCube : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("PlayerCharacter has hit the DoomCube");
        }
    }
}