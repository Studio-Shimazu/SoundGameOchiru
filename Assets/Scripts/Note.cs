using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    // 下に落ちる
    // TODO:落ちる速度を曲と判定場所との距離から設定する必要がある
    // ・音を１小節分遅らせて鳴らす => ノーツは1小節分早く生成される
    // ・判定場所に来た時に音がなればいい => 速度:判定場所までの距離/1小節の長さ(s)
    float speed;

    //・1小節の時間はいくらか？:BPMから計算する(4*60/BPM)
    // BPM120
    // => 60秒間に120回音が入る
    // => 1回あたり0.5秒(60/120)
    // => 1小節:音が4回なる => 4*0.5 = 2秒 => 1小節の長さ=2秒

    //・判定場所までの距離はいくらか:Unity側の問題
    // 70-(-50) => 120


    private void Start()
    {
        speed = 60; // 120/2
    }

    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
}
