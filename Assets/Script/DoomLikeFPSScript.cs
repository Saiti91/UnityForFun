using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomLikeFPSScript : MonoBehaviour
{
    public Transform cameraTransform;

    public float speed;
    public float yawRotationSpeed;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cameraTransform.position += cameraTransform.rotation*Vector3.forward * (Time.deltaTime * speed); 
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            cameraTransform.position -= cameraTransform.rotation*Vector3.forward * (Time.deltaTime * speed); 
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            cameraTransform.Rotate(Vector3.up, -yawRotationSpeed*Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            cameraTransform.Rotate(Vector3.up, +yawRotationSpeed*Time.deltaTime); 
        }
    }
}
