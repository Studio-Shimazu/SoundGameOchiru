using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator : MonoBehaviour
{
    // [SerializeField] Note notePrefab;
    // Noteを生成する
    // Prefab:Instantiate

    [SerializeField] ObjectPool objectPool;

    private void Awake()
    {
        objectPool.CreatePool(10);
    }

    public void SpawnNote(Vector3 pos)
    {
        // Instantiate(生成したいもの, 場所, 角度);
        // Instantiate(notePrefab, pos, Quaternion.identity);
        objectPool.GetObj(pos);
    }
}
