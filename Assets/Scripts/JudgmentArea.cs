using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgmentArea : MonoBehaviour
{
    // ノーツが落ちてきた時に、キーボードを押したら判定したい
    // ・キー入力
    // ・近くにノーツがあるのか:Rayをばして当たったら近い！
    // ・どれぐらいの近さなのか => 評価
    [SerializeField] float radius;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("aを入力");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
            if (hit2D)
            {
                Debug.Log("ノーツがぶつかった");
                float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y);
                if (distance < 3)
                {
                    Debug.Log("Good!");
                }
                else if (distance < 5)
                {
                    Debug.Log("まぁまぁ!");
                }
                else
                {
                    Debug.Log("えーー!");
                }
                // ぶつかったものを破壊する
                Destroy(hit2D.collider.gameObject);
            }
        }
    }

    // 可視化ツール
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
