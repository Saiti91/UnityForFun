using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DukeNukemScriptController : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float cameraSpeed;
    [SerializeField] private float yawRotationSpeed;
    public Vector2 turn;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cameraTransform.position += cameraTransform.rotation*Vector3.forward * (Time.deltaTime * cameraSpeed); 
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            cameraTransform.position -= cameraTransform.rotation*Vector3.forward * (Time.deltaTime * cameraSpeed); 
        }

        turn.x = Input.GetAxis("Mouse X");
        cameraTransform.Rotate(Vector3.up, turn.x*yawRotationSpeed *Time.deltaTime);
    }
}
