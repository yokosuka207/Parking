using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emotionRotation : MonoBehaviour
{
    public RawImage imageToMove; // 2D画像
    createEmotion colCar;

     // 生成元オブジェクトへの参照

    public void SetCreatorObject(createEmotion car)
    {
        colCar = car;
    }

    void Update()
    {
        if (imageToMove != null && colCar != null)
        {
            // 3Dオブジェクトの位置を取得し、それを2D画像の位置に反映
            Vector3 worldPosition = colCar.transform.position;
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(worldPosition);
            imageToMove.transform.position = screenPosition;

            Destroy(gameObject, 0.2f);
        }
    }
}
