using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgmentArea : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] GameManager gameManager = default;
    [SerializeField] KeyCode keyCode;
    private void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            // 2つのノーツがきたときに、上のノーツが消えてしまう => 下優先
            // => 複数のノーツを取得して、一番下を消す
            RaycastHit2D[] hits2D = Physics2D.CircleCastAll(transform.position, radius, Vector3.zero);
            // 一番下のやつを消す

            if (hits2D.Length == 0)
            {
                return;
            }
            // 一度y座標が小さいもの順で並べ替える(ソートする)
            List<RaycastHit2D> raycastHit2Ds = hits2D.ToList();
            raycastHit2Ds.Sort((a,b) => (int)(a.transform.position.y - b.transform.position.y));
            // 0番目の要素を消す
            RaycastHit2D hit2D = raycastHit2Ds[0];

            // RaycastHit2D hit2D = Physics2D.CircleCast(transform.position, radius, Vector3.zero);
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
                // Destroy(hit2D.collider.gameObject);
                hit2D.collider.gameObject.SetActive(false);
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
