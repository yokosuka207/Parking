using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRotatte : MonoBehaviour
{
    private GameObject car;
    private exitMove exit;
    public float riseSpeed = 2.0f; // è„è∏ë¨ìx
    public float moveSpeed = 0.0f; // âÒì]ë¨ìx
    private float rotationSpeed = 90.0f; // âÒì]ë¨ìx

    private void Start()
    {
        car = GameObject.Find("Car");
        exit = car.GetComponent<exitMove>();
    }
    void Update()
    {
        // è„è∏
        transform.position += (Vector3.up * riseSpeed * Time.deltaTime);
        // zé≤é¸ÇËÇÃâÒì]
        transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f) * moveSpeed * rotationSpeed * Time.deltaTime);

        Destroy(gameObject, 1.5f);
    }
}
