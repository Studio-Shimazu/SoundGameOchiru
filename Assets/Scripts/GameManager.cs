using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    // TODO:ゲーム開始の実装
    // コルーチンを使う:時間を制御したい

    // タイムラインを再生したい
    [SerializeField] PlayableDirector playableDirector;


    void Start()
    {
        StartCoroutine(GameMain());
    }

    IEnumerator GameMain()
    {
        Debug.Log("3");
        yield return new WaitForSeconds(1);
        Debug.Log("2");
        yield return new WaitForSeconds(1);
        Debug.Log("1");
        yield return new WaitForSeconds(1);
        Debug.Log("GO!");
        yield return new WaitForSeconds(0.3f);
        Debug.Log("ゲーム開始!");
        playableDirector.Play();
    }
}
