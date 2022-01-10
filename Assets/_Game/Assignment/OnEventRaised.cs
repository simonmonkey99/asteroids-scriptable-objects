using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEventRaised : MonoBehaviour
{
    public GameEvent Event;

    private void OnTriggerExit2D(Collider2D other)
    {
        
        Event.Raise(); 
        
        
    }
}
