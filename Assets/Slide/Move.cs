using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float counter = 0;
    float move = -0.5f;
    bool sw;
    public void OnClickPlus()
    {
        sw = false;
    }
    void Start()
    {
        sw = true;
    }
    void Update()
    {
        if (sw == false&&v.counttt<=400)
        {
            Vector3 p = new Vector3(move, 0, 0);
            transform.Translate(p);
            counter = move + counter;
           
            //countが100になれば-1を掛けて逆方向に動かす
            if (counter <= -8.5f )
            {
                counter = 0;
                move = 0;
                v.counttt = v.counttt + 200;
                sw = true;
            }
            //sw = true;
            if (sw == true)
            {
                move = -0.5f;
            }
        }
    }
}
