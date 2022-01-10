using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventListener : MonoBehaviour
{
   
    [SerializeField]
    private Camera cam;
    
        public GameEvent Event;
        public GameObject ship;

        private void OnEnable()
        {
            Event.RegisterListener(this);
            
        }

        private void OnApplicationQuit()
        {
            Debug.Log("quit");
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Vector3 screenpoint = cam.WorldToScreenPoint(transform.position);
            screenpoint = new Vector3(Screenwrap(screenpoint.x, cam.pixelWidth), Screenwrap(screenpoint.y, cam.pixelHeight), screenpoint.z);
            transform.position = cam.ScreenToWorldPoint(screenpoint);
           
        }
        private float Screenwrap(float pos, float maxdist)
        {
            pos %= maxdist;
            return pos < 0 ? pos + maxdist : pos;
        }
   
               
               
}
