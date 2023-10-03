using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    RaycastHit _hit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Unity��ł̑���擾
        if (Application.isEditor)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(_ray, out _hit))
                {
                    // �I�����ꂽ�I�u�W�F�N�g�ւ̏���
                    HitObj();
                }
            }
        }
        // �[����ł̑���擾
        else
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.touches[0];
                if (touch.phase == TouchPhase.Began)
                {
                    var _ray = Camera.main.ScreenPointToRay(touch.position);
                    if (Physics.Raycast(_ray, out _hit))
                    {
                        // �I�����ꂽ�I�u�W�F�N�g�ւ̏���
                        HitObj();
                    }
                }
            }
        }
    }

    // �I�����ꂽ�I�u�W�F�N�g�ւ̏���
    private void HitObj()
    {
        print(_hit.transform.name);
        _hit.transform.position += new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), 0);


    }

}
