using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3 : MonoBehaviour
{
    float counter = 0;
    float move = -0.5f;
    public float timeOut=5.0f;
    private float timeElapsed = 0.0f;
    bool set;
   
    void Start()
    {
        set= true;
    }
    void Update()
    {

        timeElapsed = timeElapsed+Time.deltaTime;
        //Debug.Log(timeElapsed);

        if (timeElapsed >= 5 && v.counttt <600f && set == true)
        {
            Vector3 p = new Vector3(move, 0, 0);
            transform.Translate(p);
            counter = move + counter;

            //countが100になれば-1を掛けて逆方向に動かす
            if (counter <= -8.5)
            {
                counter = 0;
                move = 0;
                v.counttt = v.counttt + 200;
                timeElapsed = 0.0f;
            }

            if(v.counttt == 600)
            {
                set = false;
            }

            if ( set == true)
            {
                move = -0.5f;
            }
        }

        if ( timeElapsed >= 5 && v.counttt > 0 && set == false)
        {
            Vector3 p = new Vector3(move, 0, 0);
            transform.Translate(p);
            counter = move + counter;
          
        if (counter >= 8.5f )
        {
            counter = 0;
            move = 0;
            v.counttt = v.counttt - 200;
            timeElapsed = 0.0f;
            }

            if (v.counttt == 0)
        {
            set = true;
        }

        if (set == false)
        {
            move = 0.5f;
        }

    }
}
}
