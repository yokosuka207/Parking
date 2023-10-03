using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe : MonoBehaviour
{
    [SerializeField] GameObject target;
    Vector2 speed;
    RaycastHit _hit;
    float mouse_sensitivity = 0.1f;
    bool collisionFlag;
    Vector3 oldPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ドラッグ中もしくはスワイプ中
        if (Input.GetMouseButton(0))
        {
            collisionFlag = false;

            var _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(_ray, out _hit))
            {
                // 選択されたオブジェクトへの処理
                if (_hit.transform.name == target.transform.name)
                    sride();
            }
        }

        if (!collisionFlag)
            target.transform.Translate(speed.x, 0.0f, speed.y);
    }

    void sride()
    {
        float dx, dy;
        speed.x = 0.0f; 
        speed.y = 0.0f;

        //移動量を計算
        dx = Input.GetAxis("Mouse X") * mouse_sensitivity;
        dy = Input.GetAxis("Mouse Y") * mouse_sensitivity;

        Debug.Log(dx);

        //一定以上ドラッグしたら移動する
        if (dx > 0.01f)
        {
            speed.x = 0.01f;
            speed.y = 0.0f;
        }
        if (dx < -0.01f)
        {
            speed.x = -0.01f;
            speed.y = 0.0f;
        }
        if (dy > 0.01f)
        {
            speed.x = 0.0f;
            speed.y = 0.01f;
        }
        if (dy < -0.01f)
        {
            speed.x = 0.0f;
            speed.y = -0.01f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Car")
        {
            collisionFlag = true;
            Debug.Log("aaaa");
        }
    }
}
