using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MathewHartley
{
    public class DeathFloorRespawn : MonoBehaviour
    {
        Scene thisScene;
        string sceneName;
        /// <summary>
        /// Sets the scene to load uon contact with the death floor as the current scene
        /// </summary>
        private void Start()
        {
            thisScene = SceneManager.GetActiveScene();
            sceneName = thisScene.name;
            Debug.Log("Active Scene is '" + thisScene + "'");
        }

        /// <summary>
        /// Reloads the current scene when the player character contacts the death floor
        /// </summary>
        /// <param name="collision"></param>
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("PlayerCharacter has hit the DoomCube");
            SceneManager.LoadScene(sceneName);
        }
    }
}