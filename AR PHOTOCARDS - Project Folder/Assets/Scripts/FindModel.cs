using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindModel : MonoBehaviour
{
    Mando mando;


    public void RotateRight()
    {
        if (mando == null)
        {
            mando = FindObjectOfType<Mando>();
        }

        mando.rotateRight = true;
    }

    public void StopRotateRight()
    {
        mando.rotateRight = false;
    }

    public void RotateLeft()
    {
        if (mando == null)
        {
            mando = FindObjectOfType<Mando>();
        }

        mando.rotateLeft = true;
    }

    public void StopRotateLeft()
    {
        mando.rotateLeft = false;
    }

    public void StopRotating()
    {
            mando.dontRotate = true;
    }
}