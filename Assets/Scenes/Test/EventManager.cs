using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    public class EventManager
    {
        //This will contain all of our events
        //Event delegates have two parts
        //the DELEGATE which is the type of event
        //the EVENT which gets announced

        //THIS is the TYPE of event we will call
        public delegate void VoidDelegate();

        //THIS is the EVENT itself
        public static VoidDelegate OnTeleportEvent;
        public static VoidDelegate OnChangeColourEvent;
        public static VoidDelegate OnButtonActivate;
    }
}