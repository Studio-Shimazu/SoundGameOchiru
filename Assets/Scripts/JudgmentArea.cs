using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgmentArea : MonoBehaviour
{
    //・レーンの判定を3つにする
    //・ボタンの入力を3つ受け付ける(A,S,D)
    [SerializeField] float radius;
    [SerializeField] GameManager gameManager = default;
    [SerializeField] KeyCode keyCode;
    private void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            Debug.Log("aを入力");
            RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
            if (hit2D)
            {
                float distance = Mathf.Abs(hit2D.transform.position.y - transform.position.y);
                if (distance < 3)
                {
                    gameManager.AddScore(100);
                }
                else if (distance < 5)
                {
                    gameManager.AddScore(10);
                }
                else
                {
                    gameManager.AddScore(0);
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
