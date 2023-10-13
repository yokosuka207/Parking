using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitMove : MonoBehaviour
{
    [SerializeField] public GameObject[] roads;
    [SerializeField] private GameObject coin;
    [SerializeField] private float moveSpeed = 0;
    private int objNum = 0;
    private int num = 0;
    private bool isMove = false;
    private bool isCoin = false;
    carMove car;

    // Update is called once per frame
    void Start()
    {
        car = GetComponent<carMove>();
    }

    private void Update()
    {

        if (isMove && num < roads.Length)
        {
            //move();
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }

        else if (num == roads.Length)
        {
            objNum++;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {   
        if (other.transform.CompareTag("Road") && !isMove)
        {
            for (int i = 0; i <= roads.Length; i++)
            {
                if (other.gameObject == roads[i])
                {
                    Debug.Log("‚Í‚¢‚½");
                    num = i;
                    isMove = true;
                    car.SetMoveFlag(false);
                    transform.LookAt(new Vector3(roads[num].transform.position.x, car.transform.position.y, roads[num].transform.position.z));

                    if (!isCoin)
                    {
                        if (num == 0)
                        {
                            Instantiate(coin, roads[num].transform.position, Quaternion.Euler(0, 0, 90));
                        }
                        else
                        {
                            Instantiate(coin, roads[num - 1].transform.position, Quaternion.Euler(0, 0, 90));
                            isCoin = true;
                        }
                    }

                    break;
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (num >= roads.Length)
        {
            return;
        }


        float distanceToNextObject = Vector3.Distance(transform.position, roads[num].transform.position);

        if (distanceToNextObject <= 0.6f)
        {
            if (num < roads.Length - 1)
            {
                Debug.Log(num);
                Debug.Log(roads.Length);
                num++;
                transform.LookAt(new Vector3(roads[num].transform.position.x, car.transform.position.y, roads[num].transform.position.z));

            }
        }
    }

    private void move()
    {
        
//        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }

    public bool GetMove()
    {
        return isMove;
    }
}
