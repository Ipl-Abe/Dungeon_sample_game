using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingCamera : MonoBehaviour
{
    public GameObject cameraToTrack;
    private GameObject pivot;
    private Quaternion newRotation;

    private float initialPosX;
    private float initialPosY;
    private float initialPosZ;

    // Start is called before the first frame update
    void Start()
    {
        // initialPosX = cameraToTrack.transform.position.x;
        // initialPosY = cameraToTrack.transform.position.y;
        // initialPosZ = cameraToTrack.transform.position.z;

        // pivot = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //Here I translate my Gamobject
        // gameObject.transform.localPosition = new Vector3 (-1* (cameraToTrack.transform.position.x - initialPosX), -1* (cameraToTrack.transform.position.y - initialPosY), -1* (cameraToTrack.transform.position.z - initialPosZ));
 
        // //Here I rotate the pivot
        // newRotation.eulerAngles = new Vector3(cameraToTrack.transform.eulerAngles.z, cameraToTrack.transform.eulerAngles.y, -1 * cameraToTrack.transform.eulerAngles.x);
        // newRotation = Quaternion.Inverse (newRotation);
        // newRotation *= Quaternion.Euler (0, 90, 0);
        // pivot.transform.rotation = newRotation;
    }
}

