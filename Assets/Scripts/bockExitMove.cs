using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bockExitMove : MonoBehaviour
{
    private GameObject obj;
    exitMove exit;

    private bool isBack;
    private bool isBool;

    private void Start()
    {
        obj = transform.parent.gameObject;
        exit = obj.GetComponent<exitMove>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!exit.GetMove())
        {
            if (other.transform.CompareTag("Road") && !isBool)
            {
                isBack = true;
                isBool = true;
            }
        }
    }

    public bool GetisBack()
    {
        return isBack;
    }
    public void SetisBack(bool back)
    {
        isBack = back;
    }
}
