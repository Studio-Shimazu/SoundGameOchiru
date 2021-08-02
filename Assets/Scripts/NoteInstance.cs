using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{
    [SerializeField] NoteGenerator noteGenerator = default;
    public void NoteEvent()
    {
        noteGenerator.SpawnNote(new Vector3(0, 10, 0)); // ノーツを生成
    }

    // CとDとGで別の場所に生成したい！ => 別の関数を作る
    public void NoteEventC()
    {
        noteGenerator.SpawnNote(new Vector3(-30, 10, 0)); // ノーツを生成
    }
    public void NoteEventD()
    {
        noteGenerator.SpawnNote(new Vector3(0, 10, 0)); // ノーツを生成
    }
    public void NoteEventG()
    {
        noteGenerator.SpawnNote(new Vector3(30, 10, 0)); // ノーツを生成
    }

}
