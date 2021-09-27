using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;

public class theme_change : MonoBehaviourPunCallbacks

{

    public PhotonView photonView;//pun使うために必用な奴

    public GameObject theme_canvas;

    public GameObject theme_button;

    public GameObject text;

    private bool tb;
    private int pn;
    private Room pc;

    public GameObject matchingtext;
    public Text matchingnum;

    public GameObject ico1;
    public GameObject ico2;
    public GameObject ico3;
    public GameObject ico4;
    public GameObject ico5;
    public GameObject ico6;
    public GameObject ico7;
    public GameObject ico8;
    public GameObject ico9;
    public GameObject ico10;

    public GameObject dico1;
    public GameObject dico2;
    public GameObject dico3;
    public GameObject dico4;
    public GameObject dico5;
    public GameObject dico6;
    public GameObject dico7;
    public GameObject dico8;
    public GameObject dico9;
    public GameObject dico10;

    public GameObject sico1;
    public GameObject sico2;
    public GameObject sico3;
    public GameObject sico4;
    public GameObject sico5;
    public GameObject sico6;
    public GameObject sico7;
    public GameObject sico8;
    public GameObject sico9;
    public GameObject sico10;

    // Start is called before the first frame update
    void Start()
    {
        tb = false;
        pn = 0;
        v.ep = false;
        pc = PhotonNetwork.CurrentRoom;
        matchingtext.gameObject.SetActive(true);

        ico1.gameObject.SetActive(false);
        ico2.gameObject.SetActive(false);
        ico3.gameObject.SetActive(false);
        ico4.gameObject.SetActive(false);
        ico5.gameObject.SetActive(false);
        ico6.gameObject.SetActive(false);
        ico7.gameObject.SetActive(false);
        ico8.gameObject.SetActive(false);
        ico9.gameObject.SetActive(false);
        ico10.gameObject.SetActive(false);

        dico1.gameObject.SetActive(false);
        dico2.gameObject.SetActive(false);
        dico3.gameObject.SetActive(false);
        dico4.gameObject.SetActive(false);
        dico5.gameObject.SetActive(false);
        dico6.gameObject.SetActive(false);
        dico7.gameObject.SetActive(false);
        dico8.gameObject.SetActive(false);
        dico9.gameObject.SetActive(false);
        dico10.gameObject.SetActive(false);

        sico1.gameObject.SetActive(false);
        sico2.gameObject.SetActive(false);
        sico3.gameObject.SetActive(false);
        sico4.gameObject.SetActive(false);
        sico5.gameObject.SetActive(false);
        sico6.gameObject.SetActive(false);
        sico7.gameObject.SetActive(false);
        sico8.gameObject.SetActive(false);
        sico9.gameObject.SetActive(false);
        sico10.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        matchingtext.gameObject.SetActive(true);
        if (pc.PlayerCount == 1)
        {
            ico1.gameObject.SetActive(true);
        }
        if (pc.PlayerCount == 2)
        {
            ico1.gameObject.SetActive(true);
            ico2.gameObject.SetActive(true);
        }
        if (pc.PlayerCount == 3)
        {
            ico1.gameObject.SetActive(true);
            ico2.gameObject.SetActive(true);
            ico3.gameObject.SetActive(true);
        }
        if (pc.PlayerCount == 4)
        {
            ico1.gameObject.SetActive(true);
            ico2.gameObject.SetActive(true);
            ico3.gameObject.SetActive(true);
            ico4.gameObject.SetActive(true);
        }
        if (pc.PlayerCount == 5)
        {
            ico1.gameObject.SetActive(true);
            ico2.gameObject.SetActive(true);
            ico3.gameObject.SetActive(true);
            ico4.gameObject.SetActive(true);
            ico5.gameObject.SetActive(true);
        }
        if (pc.PlayerCount == 6)
        {
            ico1.gameObject.SetActive(true);
            ico2.gameObject.SetActive(true);
            ico3.gameObject.SetActive(true);
            ico4.gameObject.SetActive(true);
            ico5.gameObject.SetActive(true);
            ico6.gameObject.SetActive(true);
        }
        if (pc.PlayerCount == 7)
        {
            ico1.gameObject.SetActive(true);
            ico2.gameObject.SetActive(true);
            ico3.gameObject.SetActive(true);
            ico4.gameObject.SetActive(true);
            ico5.gameObject.SetActive(true);
            ico6.gameObject.SetActive(true);
            ico7.gameObject.SetActive(true);
        }
        if (pc.PlayerCount == 8)
        {
            ico1.gameObject.SetActive(true);
            ico2.gameObject.SetActive(true);
            ico3.gameObject.SetActive(true);
            ico4.gameObject.SetActive(true);
            ico5.gameObject.SetActive(true);
            ico6.gameObject.SetActive(true);
            ico7.gameObject.SetActive(true);
            ico8.gameObject.SetActive(true);
        }
        if (pc.PlayerCount == 9)
        {
            ico1.gameObject.SetActive(true);
            ico2.gameObject.SetActive(true);
            ico3.gameObject.SetActive(true);
            ico4.gameObject.SetActive(true);
            ico5.gameObject.SetActive(true);
            ico6.gameObject.SetActive(true);
            ico7.gameObject.SetActive(true);
            ico8.gameObject.SetActive(true);
            ico9.gameObject.SetActive(true);
        }
        if (pc.PlayerCount == 10)
        {
            ico1.gameObject.SetActive(true);
            ico2.gameObject.SetActive(true);
            ico3.gameObject.SetActive(true);
            ico4.gameObject.SetActive(true);
            ico5.gameObject.SetActive(true);
            ico6.gameObject.SetActive(true);
            ico7.gameObject.SetActive(true);
            ico8.gameObject.SetActive(true);
            ico9.gameObject.SetActive(true);
            ico10.gameObject.SetActive(true);
        }

        if (pc.MaxPlayers == 2)
        {
            if (pc.PlayerCount == 1)
            {
                dico1.gameObject.SetActive(true);
                dico2.gameObject.SetActive(true);
            }
            else
            {
                dico1.gameObject.SetActive(false);
                dico2.gameObject.SetActive(false);
            }
        }
        if (pc.MaxPlayers == 3)
        {
            if (pc.PlayerCount <= 2)
            {
                dico1.gameObject.SetActive(true);
                dico2.gameObject.SetActive(true);
                dico3.gameObject.SetActive(true);
            }
            else
            {
                dico1.gameObject.SetActive(false);
                dico2.gameObject.SetActive(false);
                dico3.gameObject.SetActive(false);
            }
        }
        if (pc.MaxPlayers == 4)
        {
            if (pc.PlayerCount <= 3)
            {
                dico1.gameObject.SetActive(true);
                dico2.gameObject.SetActive(true);
                dico3.gameObject.SetActive(true);
                dico4.gameObject.SetActive(true);
            }
            else
            {
                dico1.gameObject.SetActive(false);
                dico2.gameObject.SetActive(false);
                dico3.gameObject.SetActive(false);
                dico4.gameObject.SetActive(false);
            }
        }
        if (pc.MaxPlayers == 5)
        {
            if (pc.PlayerCount <= 4)
            {
                dico1.gameObject.SetActive(true);
                dico2.gameObject.SetActive(true);
                dico3.gameObject.SetActive(true);
                dico4.gameObject.SetActive(true);
                dico5.gameObject.SetActive(true);
            }
            else
            {
                dico1.gameObject.SetActive(false);
                dico2.gameObject.SetActive(false);
                dico3.gameObject.SetActive(false);
                dico4.gameObject.SetActive(false);
                dico5.gameObject.SetActive(false);
            }
        }
        if (pc.MaxPlayers == 6)
        {
            if (pc.PlayerCount <= 5)
            {
                dico1.gameObject.SetActive(true);
                dico2.gameObject.SetActive(true);
                dico3.gameObject.SetActive(true);
                dico4.gameObject.SetActive(true);
                dico5.gameObject.SetActive(true);
                dico6.gameObject.SetActive(true);
            }
            else
            {
                dico1.gameObject.SetActive(false);
                dico2.gameObject.SetActive(false);
                dico3.gameObject.SetActive(false);
                dico4.gameObject.SetActive(false);
                dico5.gameObject.SetActive(false);
                dico6.gameObject.SetActive(false);
            }
        }
        if (pc.MaxPlayers == 7)
        {
            if (pc.PlayerCount <= 6)
            {
                dico1.gameObject.SetActive(true);
                dico2.gameObject.SetActive(true);
                dico3.gameObject.SetActive(true);
                dico4.gameObject.SetActive(true);
                dico5.gameObject.SetActive(true);
                dico6.gameObject.SetActive(true);
                dico7.gameObject.SetActive(true);
            }
            else
            {
                dico1.gameObject.SetActive(false);
                dico2.gameObject.SetActive(false);
                dico3.gameObject.SetActive(false);
                dico4.gameObject.SetActive(false);
                dico5.gameObject.SetActive(false);
                dico6.gameObject.SetActive(false);
                dico7.gameObject.SetActive(false);
            }
        }
        if (pc.MaxPlayers == 8)
        {
            if (pc.PlayerCount <= 7)
            {
                dico1.gameObject.SetActive(true);
                dico2.gameObject.SetActive(true);
                dico3.gameObject.SetActive(true);
                dico4.gameObject.SetActive(true);
                dico5.gameObject.SetActive(true);
                dico6.gameObject.SetActive(true);
                dico7.gameObject.SetActive(true);
                dico8.gameObject.SetActive(true);
            }
            else
            {
                dico1.gameObject.SetActive(false);
                dico2.gameObject.SetActive(false);
                dico3.gameObject.SetActive(false);
                dico4.gameObject.SetActive(false);
                dico5.gameObject.SetActive(false);
                dico6.gameObject.SetActive(false);
                dico7.gameObject.SetActive(false);
                dico8.gameObject.SetActive(false);
            }
        }
        if (pc.MaxPlayers == 9)
        {
            if (pc.PlayerCount <= 8)
            {
                dico1.gameObject.SetActive(true);
                dico2.gameObject.SetActive(true);
                dico3.gameObject.SetActive(true);
                dico4.gameObject.SetActive(true);
                dico5.gameObject.SetActive(true);
                dico6.gameObject.SetActive(true);
                dico7.gameObject.SetActive(true);
                dico8.gameObject.SetActive(true);
                dico9.gameObject.SetActive(true);
            }
            else
            {
                dico1.gameObject.SetActive(false);
                dico2.gameObject.SetActive(false);
                dico3.gameObject.SetActive(false);
                dico4.gameObject.SetActive(false);
                dico5.gameObject.SetActive(false);
                dico6.gameObject.SetActive(false);
                dico7.gameObject.SetActive(false);
                dico8.gameObject.SetActive(false);
                dico9.gameObject.SetActive(false);
            }
        }
        if (pc.MaxPlayers == 10)
        {
            if (pc.PlayerCount <= 9)
            {
                dico1.gameObject.SetActive(true);
                dico2.gameObject.SetActive(true);
                dico3.gameObject.SetActive(true);
                dico4.gameObject.SetActive(true);
                dico5.gameObject.SetActive(true);
                dico6.gameObject.SetActive(true);
                dico7.gameObject.SetActive(true);
                dico8.gameObject.SetActive(true);
                dico9.gameObject.SetActive(true);
                dico10.gameObject.SetActive(true);
            }
            else
            {
                dico1.gameObject.SetActive(false);
                dico2.gameObject.SetActive(false);
                dico3.gameObject.SetActive(false);
                dico4.gameObject.SetActive(false);
                dico5.gameObject.SetActive(false);
                dico6.gameObject.SetActive(false);
                dico7.gameObject.SetActive(false);
                dico8.gameObject.SetActive(false);
                dico9.gameObject.SetActive(false);
                dico10.gameObject.SetActive(false);
            }
        }
        if (v.count == 0)
        {
            sico1.gameObject.SetActive(false);
            sico2.gameObject.SetActive(false);
            sico3.gameObject.SetActive(false);
            sico4.gameObject.SetActive(false);
            sico5.gameObject.SetActive(false);
            sico6.gameObject.SetActive(false);
            sico7.gameObject.SetActive(false);
            sico8.gameObject.SetActive(false);
            sico9.gameObject.SetActive(false);
            sico10.gameObject.SetActive(false);
        }
        if (v.count == 1)
        {
            sico1.gameObject.SetActive(true);
        }
        if (v.count == 2)
        {
            sico1.gameObject.SetActive(true);
            sico2.gameObject.SetActive(true);
        }
        if (v.count == 3)
        {
            sico1.gameObject.SetActive(true);
            sico2.gameObject.SetActive(true);
            sico3.gameObject.SetActive(true);
        }
        if (v.count == 4)
        {
            sico1.gameObject.SetActive(true);
            sico2.gameObject.SetActive(true);
            sico3.gameObject.SetActive(true);
            sico4.gameObject.SetActive(true);
        }
        if (v.count == 5)
        {
            sico1.gameObject.SetActive(true);
            sico2.gameObject.SetActive(true);
            sico3.gameObject.SetActive(true);
            sico4.gameObject.SetActive(true);
            sico5.gameObject.SetActive(true);
        }
        if (v.count == 6)
        {
            sico1.gameObject.SetActive(true);
            sico2.gameObject.SetActive(true);
            sico3.gameObject.SetActive(true);
            sico4.gameObject.SetActive(true);
            sico5.gameObject.SetActive(true);
            sico6.gameObject.SetActive(true);
        }
        if (v.count == 7)
        {
            sico1.gameObject.SetActive(true);
            sico2.gameObject.SetActive(true);
            sico3.gameObject.SetActive(true);
            sico4.gameObject.SetActive(true);
            sico5.gameObject.SetActive(true);
            sico6.gameObject.SetActive(true);
            sico7.gameObject.SetActive(true);
        }
        if (v.count == 8)
        {
            sico1.gameObject.SetActive(true);
            sico2.gameObject.SetActive(true);
            sico3.gameObject.SetActive(true);
            sico4.gameObject.SetActive(true);
            sico5.gameObject.SetActive(true);
            sico6.gameObject.SetActive(true);
            sico7.gameObject.SetActive(true);
            sico8.gameObject.SetActive(true);
        }
        if (v.count == 9)
        {
            sico1.gameObject.SetActive(true);
            sico2.gameObject.SetActive(true);
            sico3.gameObject.SetActive(true);
            sico4.gameObject.SetActive(true);
            sico5.gameObject.SetActive(true);
            sico6.gameObject.SetActive(true);
            sico7.gameObject.SetActive(true);
            sico8.gameObject.SetActive(true);
            sico9.gameObject.SetActive(true);
        }
        if (v.count == 10)
        {
            sico1.gameObject.SetActive(true);
            sico2.gameObject.SetActive(true);
            sico3.gameObject.SetActive(true);
            sico4.gameObject.SetActive(true);
            sico5.gameObject.SetActive(true);
            sico6.gameObject.SetActive(true);
            sico7.gameObject.SetActive(true);
            sico8.gameObject.SetActive(true);
            sico9.gameObject.SetActive(true);
            sico10.gameObject.SetActive(true);
        }
        v.all_player = pc.PlayerCount;
        matchingnum.text = pc.MaxPlayers + "人中" + v.count + "人が準備完了を押しました";
        photonView.RPC(nameof(room_creator), RpcTarget.MasterClient);
        if (pc.PlayerCount == pc.MaxPlayers && v.count == pc.MaxPlayers)
        {
            matchingtext.gameObject.SetActive(false);
            pc.IsVisible = false;
            if (tb)
            {
                theme_button.gameObject.SetActive(true);
                text.gameObject.SetActive(false);
            }
            if (tb == false)
            {
                text.gameObject.SetActive(true);
                theme_button.gameObject.SetActive(false);
            }
            if (v.ep) theme_canvas.gameObject.SetActive(false);
            int theme_rnd = (int)Random.Range(0.0f, 3.0f);//カテゴリーをランダム
            if (theme_rnd == 0) vegetable();
            if (theme_rnd == 1) animal();
            if (theme_rnd == 2) sports();
        }

        Debug.Log("参加者数 : " + pc.PlayerCount + "/最大人数 : " + pc.MaxPlayers);
        Debug.Log("v.allplayer : " + v.all_player);
    }

    public void vegetable()
    {
        //v.theme = "greatman";
        if (PhotonNetwork.IsMasterClient)
        {
            photonView.RPC(nameof(theme_set), RpcTarget.All, "vegetable");
            photonView.RPC(nameof(erase_panel), RpcTarget.All);
        }
    }

    public void animal()
    {
        //v.theme = "chaos";
        if (PhotonNetwork.IsMasterClient)
        {
            photonView.RPC(nameof(theme_set), RpcTarget.All, "animal");
            photonView.RPC(nameof(erase_panel), RpcTarget.All);
        }
    }

    public void sports()
    {
        //v.theme = "chaos";
        if (PhotonNetwork.IsMasterClient)
        {
            photonView.RPC(nameof(theme_set), RpcTarget.All, "sports");
            photonView.RPC(nameof(erase_panel), RpcTarget.All);
        }
    }

    public override void OnJoinedRoom()
    {
        Room myroom = PhotonNetwork.CurrentRoom;　//myroom変数にPhotonnetworkの部屋の現在状況を入れる。
        Photon.Realtime.Player player = PhotonNetwork.LocalPlayer;　//playerをphotonnetworkのローカルプレイヤーとする
        Debug.Log("ルーム名:" + myroom.Name);
        Debug.Log("PlayerNo" + player.ActorNumber);
        Debug.Log("プレイヤーID" + player.UserId);
        //photonView.RPC(nameof(all_player_share), RpcTarget.All, player.ActorNumber);
    }

    [PunRPC]
    void room_creator()
    {
        tb = true;
    }

    [PunRPC]
    void erase_panel()
    {
        v.ep = true;
    }

    [PunRPC]
    void theme_set(string theme)
    {
        v.theme = theme;
    }






}
