using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MathewHartley
{
    public class DeathFloorRespawn : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("PlayerCharacter has hit the DoomCube");
            SceneManager.LoadScene("World");
        }
    }
}