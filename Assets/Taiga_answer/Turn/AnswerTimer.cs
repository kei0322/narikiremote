using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//新規作成(岩下 9/5)
public class AnswerTimer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update

    public Text time_text;//残り時間

    void Start()
    {
        v.ans_time = 9.5f;//5秒
    }

    // Update is called once per frame
    void Update()
    {
        if (!v.ans_time_flag)
        {
            v.ans_time -= Time.deltaTime;
            if (v.ans_time <= 0.5f)
            {
                time_text.text = "読み込み中";
                v.turn_frag = true;
                v.ans_time_flag = true;
                v.start_flag = false;
                Debug.Log(v.turn_frag);
            }else if (v.ans_time <= 3.5f)
            {
                time_text.text = "残り" + v.ans_time.ToString("0") + "秒";
            }
            else
            {
                time_text.text = "";
            }
        }
    }
}