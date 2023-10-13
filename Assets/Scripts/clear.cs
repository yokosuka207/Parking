using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clear : MonoBehaviour
{
    [SerializeField] private GameObject imageObj;
    [SerializeField] private GameObject resetButton;
    [SerializeField] private GameObject canvasPar;
    [SerializeField] private GameObject goalCount;
    [SerializeField] private string nextStage;
    private cleaCount count;
    private bool isBool;
    private GameObject obj = null;

    private void Start()
    {
        count = goalCount.GetComponent<cleaCount>();
        //obj = GameObject.Find("Canvas1");
        //obj.SetActive(false);
    }

    private void Update()
    {
        if(count.GetClearCount() && !isBool)
        {
            Destroy(resetButton);

            //obj.SetActive(true);

            GameObject prefab = Instantiate(imageObj);
            prefab.transform.SetParent(canvasPar.transform, false);

            //count.countReset();
            isBool = true;
        }
    }

    public string GetNextStage()
    {
        string nexSta = nextStage;
        return nexSta;
    }
}
