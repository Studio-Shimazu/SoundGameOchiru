using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgmentEffect : MonoBehaviour
{
    // effectの文字の変更:GoodとかBadとか

    [SerializeField] Text text;

    public void SetText(string message, Color color)
    {
        text.text = message;
        StartCoroutine(MoveUp());
        text.color = color;
    }

    // 少し上にあげる
    IEnumerator MoveUp()
    {
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.01f);
            transform.Translate(0, 0.05f, 0);
        }
        Destroy(gameObject);
    }
}
