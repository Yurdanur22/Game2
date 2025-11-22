using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cameraHolder;
    private Vector3 offset;
    private void Start()
    {
        offset = cameraHolder.position - transform.position;    
    }
    private void Update()
    {
       /* var cameraPos = transform.position;
        cameraHolder.position = cameraPos;*/
       cameraHolder.position = transform.position + offset; 
    }



}
