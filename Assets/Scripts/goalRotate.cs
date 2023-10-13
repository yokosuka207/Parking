using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalRotate : MonoBehaviour
{
    [SerializeField] private float rotSpeed = 90.0f;
    [SerializeField] private float moveSpeed = 0.0f;
    private float step;
    private bool isRotating = false;
    private bool isTop = false;

    void Update()
    {
        if (isRotating)
        { 
            if (!isTop)
            {
                step = moveSpeed * rotSpeed * Time.deltaTime;
                transform.Rotate(0f, 0f, step);

                if (transform.rotation.eulerAngles.z >= 90.0f)
                {
                    // –Ú•W‚Ì‰ñ“]Šp“x‚É’B‚µ‚½‚ç‰ñ“]‚ð’âŽ~
                    isTop = true;
                }
            }
            else
            {
                transform.Rotate(0.0f, 0.0f, -step);

                if(transform.rotation.z <= 0.0f)
                {
                    isTop = false;
                    isRotating = false;
                }
            }
        }
    }

    public bool GetRotating()
    {
        return isRotating;
    }
    public void SetRotating(bool isRot)
    {
        isRotating = isRot;
    }
    public void SetTop(bool top)
    {
        isTop = top;
    }
}
