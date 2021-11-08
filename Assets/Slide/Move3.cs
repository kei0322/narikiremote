using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move3 : MonoBehaviour
{
    float counter = 0;//パネルが移動した量(?)
    float move = -0.5f;
    public float timeOut = 5.0f;
    private float timeElapsed = 0.0f;
    bool set;
    bool isClick;
    bool isBack;

    [SerializeField] GameObject RightButton;
    [SerializeField] GameObject LeftButton;
    void Start()
    {
        set = true;
        isClick = false;
        isBack = false;
    }

    void Update()
    {

        timeElapsed = timeElapsed + Time.deltaTime;
        Debug.Log(v.counttt);
        //Debug.Log(timeElapsed);

        if (timeElapsed >= 5)
        {
            Vector3 p = new Vector3(move, 0, 0);
            transform.Translate(p);
            //移動量
            counter = move + counter;
            MoveProcess();
        }

        if(v.counttt == 0)
        {
            RightButton.SetActive(true);
            LeftButton.SetActive(false);
        }else if(v.counttt == 600)
        {
            RightButton.SetActive(false);
            LeftButton.SetActive(true);
        }
        else
        {
            RightButton.SetActive(true);
            LeftButton.SetActive(true);
        }
    }

    private void MoveProcess()
    {
        //最後のスライド以外でかつスライドが右から左に移動するとき
        if (v.counttt < 600f && set == true)
        {
            //countが100になれば-1を掛けて逆方向に動かす
            //ある程度移動したら
            if (counter <= -8.5)
            {
                //n番目のスライド
                v.counttt = v.counttt + 200;
                OnInterval();
            }

            if (v.counttt == 600)
            {
                //向き反転
                set = false;
            }

            if (set == true)
            {
                move = -0.5f;
            }
        }//最初のスライド以外でスライドが左から右に移動するとき
        else if (v.counttt > 0 && set == false)
        {
            //左ボタンがクリックされたときだけ逆行
            if (set == false && isClick)
            {
                move = 0.5f;
            }else if(v.counttt == 600f)//巻き戻す
            {
                Debug.Log("最初に戻る");
                isBack = true;
                move = 0.5f;
            }
            if (counter >= 8.5f && !isBack)
            {
                v.counttt = v.counttt - 200;
                OnInterval();
            }
            if (counter >= (8.5f * 3.0f) && isBack)
            {
                v.counttt = 0;
                isBack = false;
                OnInterval();
            }

            if (v.counttt == 0)
            {
                set = true;
            }

        }
    }


    private void OnInterval()
    {
        counter = 0;
        move = 0;
        timeElapsed = 0.0f;
        if (isClick)
        {
            isClick = false;
            set = true;
        }
    }

    public void OnRightButton()
    {
        OnInterval();
        timeElapsed = 5.5f;
        set = true;
        isClick = true;
    }

    public void OnLeftButton()
    {
        OnInterval();
        timeElapsed = 5.5f;
        set = false;
        isClick = true;
    }
}
