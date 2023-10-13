using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCar : MonoBehaviour
{
    GameObject objParent;
    carMove car;
    exitMove exit;
    goalRotate goal;
    bool isFor;

    private void Start()
    {
        objParent = transform.parent.gameObject;
        car = objParent.GetComponent<carMove>();
        goal = GameObject.Find("Goal").GetComponent<goalRotate>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Car"))
        {
            exit = other.GetComponent<exitMove>();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.transform.CompareTag("Car") && exit.GetMove())
        {
            if (car.GetMoveFlag())
            {
                car.SetMoveFlag(false);
            }
        }

        if (other.transform.CompareTag("goal"))
        {
            goal.SetRotating(true);
            goal.SetTop(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Car") && exit.GetMove())
            car.SetMoveFlag(true);
    }
}
