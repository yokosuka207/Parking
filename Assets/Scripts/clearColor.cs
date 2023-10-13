using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clearColor : MonoBehaviour
{
    private RawImage rawImage;

    // Start is called before the first frame update
    void Start()
    {
        rawImage = GetComponent<RawImage>();

        
    }
    private void Update()
    {
        //Color color = gameObject.GetComponent<RawImage>().color;
        ////color.a = 0.9f;
        //gameObject.GetComponent<RawImage>().color = color;
    }
}
