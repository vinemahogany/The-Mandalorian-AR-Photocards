using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;

public class Mando : MonoBehaviour
{
    [SerializeField] float rotationSpeedRight;
    [SerializeField] float rotationSpeedLeft;
    float angle;

    public bool rotateRight;
    public bool rotateLeft;
    public bool dontRotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (rotateRight)
        {
            angle += Time.deltaTime;

            transform.rotation = Quaternion.Euler(0, angle * rotationSpeedRight, 0);
        }

        else if (rotateLeft)
        {
            angle -= Time.deltaTime;

            transform.rotation = Quaternion.Euler(0, angle * rotationSpeedLeft, 0);

        }
        
        else if (dontRotate)
        {
            transform.rotation = Quaternion.Euler(0, angle, 0);
        }

    }
}
