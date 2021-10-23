using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rzero : MonoBehaviour
{
    public GameObject Rb;//永井：準備完了ボタン
    public void OnClickPlus()
    {
        v.count = 0;
        v.countt = 0;
        Rb.SetActive(true);
    }
}
