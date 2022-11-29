using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] bool sceneClose = false;

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
                SceneManager.LoadScene("LevelTwo");
            }
        }
    }
}
