using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    // TODO:UIの作成
    //・カウントダウンのテキスト
    //・ゲーム終了時のリザルトパネル
    //・ゲーム中のスコア表示
    //・タイトルへ
    //・リトライボタン

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

    public void OnEndEvent()
    {
        Debug.Log("ゲーム終了:結果表示");
    }
}
