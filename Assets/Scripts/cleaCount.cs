using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaCount : MonoBehaviour
{
    [SerializeField] private int clearCount;
    private int num = 0;

    private void OnCollisionEnter(Collision col)
    {
        num++;
    }

    public bool GetClearCount()
    {
        if (num >= clearCount)
        {
            return true;
        }
        else {
            return false;
        }
    }

    public void countReset()
    {
        num = 0;
    }
}
