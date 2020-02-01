using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingCamera1 : MonoBehaviour
{
    public Transform playler;
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playler.position.x,playler.position.y, -2);
    }
}
