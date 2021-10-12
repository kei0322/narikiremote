using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Photon使うときは必ずオブジェクトにPhoton Viewをつけること！
using Photon.Pun;
using Photon.Realtime;

public class role_change : MonoBehaviourPunCallbacks
{
    //岩下
    //加藤君が作ってくれたものにかなり手を加えてます
    //具体的にタイマースタートを同期させるためにいろいろ付け加えてます
    //やってる処理は解答・出題を選択→全員が選択し終わるまで待機→全員が選択し終わったらタイマースタート&問題表示→結果発表→最初の役割選択画面に戻る

    public GameObject role_change_canvas;
    public GameObject questoner_canvas;
    public GameObject respondent_canvas;
    public GameObject button_canvas;//回答者のボタン
    public GameObject image_button;//回答者のボタン
    public GameObject timer;
    public GameObject scripts;

    private int ans;
    private int[] cho = new int[3];

    button reset;

    //9/12追記(岩下)
    private bool random_manage;
    private Player player;
    private Room pc;
    private float start_cd;
    public Text time_text;//残り時間
    public Text role_text;//役割を教える
    // Start is called before the first frame update
    void Awake()
    {
        questoner_canvas.gameObject.SetActive(false);
        respondent_canvas.gameObject.SetActive(false);
        //9/14追記(岩下)
        random_manage = true;
        player = PhotonNetwork.LocalPlayer;
        pc = PhotonNetwork.CurrentRoom;
        start_cd = 5.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("start_flagの状態" + v.start_flag);
        //9/12追記(岩下)
        if (pc.PlayerCount == pc.MaxPlayers && !v.start_flag && v.count == pc.MaxPlayers)
        {
            start_cd -= Time.deltaTime;
            if (start_cd <= 0.5f)
            {
                time_text.text = "スタート！";
            }
            else
            {
                time_text.text = start_cd.ToString("0") + "!";
            }

            if (random_manage)
            {
                random_manage = false;
                //マスターの変数を全員で共有する方法
                if (PhotonNetwork.IsMasterClient)
                {
                    v.QuestionerActorTurn++;
                    photonView.RPC(nameof(QuestionTurn), RpcTarget.All, v.QuestionerActorTurn);
                }
            }
            if (start_cd <= 0) v.wait_frag = true;
        }
        else
        {
            random_manage = true;
            start_cd = 5.5f;
        }

        if (v.wait_frag == true)
        {
            //*** パネルを開けてからタイマーの処理を開始するので順番変えない***//
            //追記
            v.wait_frag = false;
            v.start_flag = true;
            photonView.RPC(nameof(role_panel_change), RpcTarget.All);//パネルの表示と非表示を行うよ
            if (PhotonNetwork.IsMasterClient)
            {
                scripts.GetComponent<TurnBasedSystem>().StartTurn();
            }
        }
    }

    public void respondent()
    {
        questoner_canvas.gameObject.SetActive(false);
        respondent_canvas.gameObject.SetActive(true);
        photonView.RPC(nameof(ressum), RpcTarget.All);
        Debug.Log("回答者を選択します");
    }

    public void questoner()
    {
        ans = (int)Random.Range(0.0f, 3.0f);//三人の中から答えとなる人を一人選ぶ
        //ans = 1;
        if (v.theme == "vegetable")
        {
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    int r = (int)Random.Range(0.0f, 8.0f);
                    cho[i] = r;//いっぱいの中からクイズのセットを選ぶ
                }
            } while (cho[0] == cho[1] || cho[1] == cho[2] || cho[0] == cho[2]);
            //cho[0] = 2;
            //cho[1] = 7;
            //cho[2] = 3;
        }
        else if (v.theme == "animal")
        {
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    int r = (int)Random.Range(0.0f, 8.0f);
                    cho[i] = r;//いっぱいの中からクイズのセットを選ぶ
                }
            } while (cho[0] == cho[1] || cho[1] == cho[2] || cho[0] == cho[2]);
        }
        else if (v.theme == "sports")
        {
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    int r = (int)Random.Range(0.0f, 8.0f);
                    cho[i] = r;//いっぱいの中からクイズのセットを選ぶ
                }
            } while (cho[0] == cho[1] || cho[1] == cho[2] || cho[0] == cho[2]);
        }

        //ans = 2;
        photonView.RPC(nameof(answer_share), RpcTarget.All, ans);//全員の答えとなる人を0番(1番左)に設定する

        int c0 = cho[0];
        int c1 = cho[1];
        int c2 = cho[2];
        photonView.RPC(nameof(choices_share0), RpcTarget.All, c0);
        photonView.RPC(nameof(choices_share1), RpcTarget.All, c1);
        photonView.RPC(nameof(choices_share2), RpcTarget.All, c2);

        respondent_canvas.gameObject.SetActive(true);
        respondent_canvas.gameObject.SetActive(false);
        questoner_canvas.gameObject.SetActive(true);
        Debug.Log("出題者を選択します");
    }



    [PunRPC]
    void role_panel_change()
    {
        timer.gameObject.SetActive(true);
        Invoke("close_chanvas", 0.3f);
    }

    //ロールチェンジキャンバスの遅延処理
    void close_chanvas()
    {
        button_canvas.gameObject.SetActive(true);
        image_button.gameObject.SetActive(true);
        role_change_canvas.gameObject.SetActive(false);
    }

    [PunRPC]
    void ressum()
    {
        v.res_sum++;
    }

    [PunRPC]
    void answer_share(int ans)
    {
        v.answer = ans;
    }

    [PunRPC]
    void choices_share0(int c)
    {
        v.choices[0] = c;
    }
    [PunRPC]
    void choices_share1(int c)
    {
        v.choices[1] = c;
    }
    [PunRPC]
    void choices_share2(int c)
    {
        v.choices[2] = c;
    }

    //9/14追記(岩下)
    //ランダムに一人出題者を選ぶ
    [PunRPC]
    void QuestionTurn(int QuestionerX)
    {
        if (player.ActorNumber == QuestionerX)
        {
            questoner();
            role_text.text = "【出題者】";
            Debug.Log("あなたは出題者です");
        }
        else
        {
            respondent();
            role_text.text = "【回答者】";
            Debug.Log("あなたは回答者です");
        }
        Debug.Log("順番 : " + QuestionerX + "  PlayerID : " + player.ActorNumber);
    }

}
