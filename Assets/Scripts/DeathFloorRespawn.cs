using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MathewHartley
{
    /// <summary>
    /// The hazard mechanic of the game 
    /// A floor that reloads the scene if the player character falls off a platform
    /// It is scripted so that it will reload any scene it is placed in with the active scene
    /// </summary>
    public class DeathFloorRespawn : MonoBehaviour
    {
        Scene thisScene;
        string sceneName;
        /// <summary>
        /// Sets the scene to load on contact with the death floor as the current scene
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
            Debug.Log("PlayerCharacter has hit the Death Floor");
            SceneManager.LoadScene(sceneName);
        }
    }
}