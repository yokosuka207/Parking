using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createEffect : MonoBehaviour
{
    public float moveSpeed = 15.0f; // 移動速度
    public float maxXDistance = 10.0f; // x軸方向の最大移動距離
    public float maxYDistance = 10.0f; // y軸方向の最大移動距離
    public float maxZDistance = 10.0f; // y軸方向の最大移動距離

    private Vector3 randomDirection;
    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        // ランダムな移動方向を生成
        randomDirection = new Vector3(Random.Range(-maxXDistance, maxXDistance), 
            Random.Range(-maxYDistance, maxYDistance), Random.Range(-maxZDistance, maxZDistance));
    }

    // Update is called once per frame
    void Update()
    {
        // ランダムな位置に向かって移動
        transform.position += randomDirection.normalized * moveSpeed * Time.deltaTime;
        Destroy(gameObject, 0.1f);
    }
    private void OnDestroy()
    {
        randomDirection = new Vector3(Random.Range(-maxXDistance, maxXDistance),
            Random.Range(-maxYDistance, maxYDistance), Random.Range(-maxZDistance, maxZDistance));
    }
}
