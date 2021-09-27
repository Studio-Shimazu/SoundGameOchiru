using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{
    const int NOTE_POS_Y = 70;
    [SerializeField] NoteGenerator noteGenerator = default;

    // CとDとGで別の場所に生成したい！ => 別の関数を作る
    public void NoteEventC()
    {
        noteGenerator.SpawnNote(new Vector3(-30, NOTE_POS_Y, 0)); // ノーツを生成
    }
    public void NoteEventD()
    {
        noteGenerator.SpawnNote(new Vector3(0, NOTE_POS_Y, 0)); // ノーツを生成
    }
    public void NoteEventG()
    {
        noteGenerator.SpawnNote(new Vector3(30, NOTE_POS_Y, 0)); // ノーツを生成
    }

}
