using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    public GameObject BCprefab;
    [SerializeField]
    private Camera mainCam;

   void Awake()
   {
       
//int camHeight = mainCam.pixelHeight;
  //     int camWidth = mainCam.pixelWidth;
//       GameObject go = Instantiate(BCprefab, new Vector3(13f, 0, 0f), Quaternion.identity);

      // go.transform.localScale = new Vector3(1, 5, 1);
       




       //GameObject go= Instantiate(BCprefab, new Vector3(0-BCprefab.transform.localScale.x/2f, camHeight / 2f, 0), Quaternion.identity);


       //     go.transform.localScale= new Vector3(1,camHeight,1);
       //     
       //   
       //go= Instantiate(BCprefab, new Vector3(camWidth+BCprefab.transform.localScale.x/2f, camHeight / 2f, 0), Quaternion.identity);
       //
       //go.transform.localScale= new Vector3(1,camHeight,1);
       //
       //
       //go= Instantiate(BCprefab, new Vector3(camWidth/2, camHeight +BCprefab.transform.localScale.y / 2f, 0), Quaternion.identity);
//
       //go.transform.localScale = new Vector3(camWidth, 1, 1);
       //
       //
       //go= Instantiate(BCprefab, new Vector3(camWidth/2, 0 - BCprefab.transform.localScale.y / 2f, 0), Quaternion.identity);
//
       //go.transform.localScale = new Vector3(camWidth, 1, 1);


   }
    
}
