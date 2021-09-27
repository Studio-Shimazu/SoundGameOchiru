using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // オブジェクトプールとは
    // 生成:使う時 -> 表示
    // 破壊:使わない時 -> 非表示

    // そのために
    // ・あらかじめオブジェクトを複数生成して貯めておく:pool
    // ・使うときに表示する
    // ・いらなくなったら非表示にする

    [SerializeField] GameObject prefabObj;
    List<GameObject> pool;

    public void CreatePool(int maxCount)
    {
        pool = new List<GameObject>();
        for (int i=0; i<maxCount; i++)
        {
            // オブジェクト生成
            GameObject obj = Instantiate(prefabObj);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    // 使うときに場所を指定して表示する:poolの中から非表示のオブジェクトを探してくる
    public GameObject GetObj(Vector2 position)
    {
        // 使ってないものを探してくる
        for (int i=0; i< pool.Count; i++)
        {
            if (pool[i].activeSelf == false)
            {
                GameObject obj = pool[i];
                obj.transform.position = position;
                obj.SetActive(true);
                return obj;
            }
        }

        // poolの中のものを全部使ってたら? =>新たに生成
        GameObject newObj = Instantiate(prefabObj, position, Quaternion.identity);
        newObj.SetActive(false);
        pool.Add(newObj);
        return newObj;
    }
}
