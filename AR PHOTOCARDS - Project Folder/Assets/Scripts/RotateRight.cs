using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRight : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0.01f;
    [SerializeField] float zAngle = 0;
    bool rightRotate;

    private void Update()
    {
        if (rightRotate)
        {
            transform.Rotate(xAngle, yAngle, zAngle);
        }
    }
    public void onPress()
    {
        rightRotate = true;
    }

    public void onRelease()
    {
        rightRotate = false;
    }
}
