using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator : MonoBehaviour
{
    [SerializeField] Note notePrefab;
    // Noteを生成する
    // Prefab:Instantiate

    public void SpawnNote(Vector3 pos)
    {
        // Instantiate(生成したいもの, 場所, 角度);
        Instantiate(notePrefab, pos, Quaternion.identity);
    }
}
