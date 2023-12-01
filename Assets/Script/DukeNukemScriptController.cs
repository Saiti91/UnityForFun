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
        var directionIntent = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            directionIntent += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            directionIntent += Vector3.back;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            directionIntent += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            directionIntent += Vector3.right;
        }

        var normalizedDirection = directionIntent.normalized;

        cameraTransform.position += cameraTransform.rotation * normalizedDirection * (Time.deltaTime * cameraSpeed);
        turn.x = Input.GetAxis("Mouse X");
        cameraTransform.Rotate(Vector3.up, turn.x*yawRotationSpeed *Time.deltaTime);
    }
}
