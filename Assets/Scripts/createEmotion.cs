using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createEmotion : MonoBehaviour
{
    [SerializeField] public GameObject imageObj;
    [SerializeField] private GameObject canvasPar;
    bool isFor;
    bool isBool;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("goal"))
        {
            GameObject prefab = Instantiate(imageObj);
            prefab.transform.SetParent(canvasPar.transform, false);

            Vector3 worldPosition = other.transform.position;
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(worldPosition);
            screenPosition.y = screenPosition.y + 10;
            prefab.transform.position = screenPosition;

            prefab.GetComponent<emotionRotation>().SetCreatorObject(this);
        }

        if(other.transform.CompareTag("Road") && !isBool)
        {
            isFor = true;
            isBool = true;
        }
    }
    public bool GetisFor()
    {
        return isFor;
    }
    public void SetisFor(bool forw)
    {
        isFor = forw;
    }
}
