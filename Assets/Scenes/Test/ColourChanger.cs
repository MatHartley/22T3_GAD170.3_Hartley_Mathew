using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    public class ColourChanger : MonoBehaviour
    {
        float redValue;
        float greenValue;
        float blueValue;

        // This cube will change colour when the "OnChangeColourEvent" event is announced
        // Change Colour will change the colour of the cube to a random colour
        private void Start()
        {
            EventManager.OnChangeColourEvent += ChangeColour;
        }
        private void OnDisable()
        {
            EventManager.OnChangeColourEvent -= ChangeColour;
        }
        private void ChangeColour()
        {
            redValue = Random.Range(0f, 1f);
            greenValue = Random.Range(0f, 1f);
            blueValue = Random.Range(0f, 1f);

            gameObject.GetComponent<MeshRenderer>().material.color = new Color(redValue, greenValue, blueValue);
        }
    }
}