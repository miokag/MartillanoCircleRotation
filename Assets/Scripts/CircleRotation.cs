using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GridBrushBase;

public class CircleRotation : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private float rotationDirection = 1f;
    [SerializeField] private Transform rotateAround;

    void Update()
    {
        HandleRotation();

        this.transform.RotateAround(rotateAround.position, -Vector3.forward, rotationSpeed * rotationDirection * Time.deltaTime);
    }

    void HandleRotation()
    {
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            rotationDirection *= -1; 
        }
    }
}
