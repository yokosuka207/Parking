using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    clear clear;

    private void Start()
    {
        GameObject par = transform.root.gameObject;
        clear = par.GetComponent<clear>();
    }

    public void changingScene()
    {
        string nexStage = clear.GetNextStage();
        SceneManager.LoadScene(nexStage);
    }
}
