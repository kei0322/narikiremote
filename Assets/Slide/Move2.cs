using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    float counter = 0;
    float move = 0.5f;
    // public GameObject Panel;
    bool sw2;
    public void OnClickPlus()
    {
        sw2 = false;
    }
    void Start()
    {
        sw2 = true;
    }
    void Update()
    {
        if (sw2 == false && v.counttt >0)
        {
            Vector3 p = new Vector3(move, 0, 0);
            transform.Translate(p);
            counter = move + counter;

            //countが100になれば-1を掛けて逆方向に動かす
            if (counter >= 8.5f)
            {
                counter = 0;
                move = 0;
                v.counttt = v.counttt -200;
                sw2 = true;
            }
            //sw2 = true;
            if (sw2 == true)
            {
                move =0.5f;
            }
        }
    }
}
