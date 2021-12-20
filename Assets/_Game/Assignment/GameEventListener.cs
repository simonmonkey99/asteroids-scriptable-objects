using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventListener : MonoBehaviour
{
   
    [SerializeField]
    private Camera mainCam;
    
        public GameEvent Event;
       

        private void OnEnable()
        { Event.RegisterListener(this); }

        private void OnApplicationQuit()
        { Event.UnregisterListener(this); }

        public void OnEventRaised()
        {


            if (transform.position.x < 11.8f)
            {
                transform.position = new Vector3(37f,transform.position.y,0);
            }
            else if (transform.position.x > 37)
            {
                transform.position = new Vector3(11.8f,transform.position.y,0);
            }
            

           
        }
   
               
               
}
