using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// @今後やること
    /// ＊1weekで作ったものと同様のシステムを実装していく
    /// ・ノーツが落ちてくるのを3レーンにする（済）
    /// ・ノーツを叩く場所を3レーンにする（済）
    /// ・ノーツが重なった場合にうまく消えないバグ修正
    /// ・ノーツのずれ修正

    /// ＊リクエストがあればYouTubeメンバーシップへ
    /// ・ノーツが下までいったら破壊する
    /// ・オブジェクトプール（ノーツの再利用）
    /// </summary>


    //・カウントダウンのテキスト
    [SerializeField] Text countDownText = default;
    //・ゲーム終了時のリザルトパネル
    [SerializeField] GameObject resultPanel = default;
    //・リトライボタン:シーンの再読み込み

    //・ゲーム中のスコア表示（スコア機能:未実装）
    [SerializeField] Text scoreText = default;
    //・タイトルへ（タイトル未実装）

    [SerializeField] PlayableDirector playableDirector;

    int score;

    void Start()
    {
        StartCoroutine(GameMain());
    }

    IEnumerator GameMain()
    {
        countDownText.text = "3";
        yield return new WaitForSeconds(1);
        countDownText.text = "2";
        yield return new WaitForSeconds(1);
        countDownText.text = "1";
        yield return new WaitForSeconds(1);
        countDownText.text = "GO!";
        yield return new WaitForSeconds(0.5f);
        countDownText.text = "";
        playableDirector.Play();
    }

    // スコア上昇:scoreの数値を大きくする&UIに反映させる
    // どのタイミングでスコアを上昇させる
    public void AddScore(int point)
    {
        score += point;
        scoreText.text = score.ToString();
    }

    public void OnEndEvent()
    {
        Debug.Log("ゲーム終了:結果表示");
        resultPanel.SetActive(true);
    }

    public void OnRetry()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
