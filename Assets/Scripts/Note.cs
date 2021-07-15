using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    // 下に落ちる

    // TODO:落ちる速度を曲と判定場所との距離から設定する必要がある
    float speed;

    private void Start()
    {
        speed = 20;
    }

    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
}
