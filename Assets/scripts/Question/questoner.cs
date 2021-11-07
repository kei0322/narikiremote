using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class questoner : MonoBehaviourPunCallbacks
{
    //public PhotonView photonView;

    public Image img;//左の画像

    public Text name;
    //public Text description;

    //偉人
    //public Sprite greatman0;
    //public Sprite greatman1;
    //public Sprite greatman2;

    //共有変数
    //private string theme="greatman";
    //private int choices = 0;
    //private int answer = 0;
    //private bool ttf = false;

    // Start is called before the first frame update
    void Start()
    {
        //v.answer = (int)Random.Range(0.0f, 3.0f);
        Debug.Log(v.answer);
    }

    // Update is called once per frame
    void Update()
    {
        if (v.theme == "vegetable") ve_image_switch();
        if (v.theme == "animal") an_image_switch();
        if (v.theme == "sports") sp_image_switch();
        if (v.ansum >= v.player_count) photonView.RPC(nameof(to_test_frag), RpcTarget.All);
        //現状Answerシーンに飛ぶ必要がないのでコメントアウトしています 岩下
        //if (v.ttf == true) SceneManager.LoadScene("Answer");
    }

    private void ve_image_switch()//野菜
    {
        for (int i = 0; i < 22; i++)
        {
            img.sprite = Resources.Load<Sprite>(v.ve_pass[v.choices[v.answer]]); name.GetComponent<Text>().text = v.ve_name[v.choices[v.answer]];
        }
        #region 旧コード
        /*
        switch (v.choices[v.answer])
        {
            case 0:
                img.sprite = Resources.Load<Sprite>("images/vegetable/burokkori-"); name.GetComponent<Text>().text = "ブロッコリー";
                break;
            case 1:
                img.sprite = Resources.Load<Sprite>("images/vegetable/pi-mnn"); name.GetComponent<Text>().text = "ピーマン";
                break;
            case 2:
                img.sprite = Resources.Load<Sprite>("images/vegetable/kyu-ri"); name.GetComponent<Text>().text = "きゅうり";
                break;
            case 3:
                img.sprite = Resources.Load<Sprite>("images/vegetable/kyabetu"); name.GetComponent<Text>().text = "キャベツ";
                break;
            case 4:
                img.sprite = Resources.Load<Sprite>("images/vegetable/retasu"); name.GetComponent<Text>().text = "レタス";
                break;
            case 5:
                img.sprite = Resources.Load<Sprite>("images/vegetable/hakusai"); name.GetComponent<Text>().text = "白菜";
                break;
            case 6:
                img.sprite = Resources.Load<Sprite>("images/vegetable/tomato"); name.GetComponent<Text>().text = "トマト";
                break;
            case 7:
                img.sprite = Resources.Load<Sprite>("images/vegetable/jagaimo"); name.GetComponent<Text>().text = "じゃがいも";
                break;
            case 8:
                img.sprite = Resources.Load<Sprite>("images/vegetable/papurika"); name.GetComponent<Text>().text = "パプリカ";
                break;
            case 9:
                img.sprite = Resources.Load<Sprite>("images/vegetable/komatuna"); name.GetComponent<Text>().text = "小松菜";
                break;
            case 10:
                img.sprite = Resources.Load<Sprite>("images/vegetable/serori-"); name.GetComponent<Text>().text = "セロリ";
                break;
            default:
                break;
        }
        */
        #endregion
    }

    private void an_image_switch()
    {
        for (int i = 0; i < 22; i++)
        {
            img.sprite = Resources.Load<Sprite>(v.an_pass[v.choices[v.answer]]); name.GetComponent<Text>().text = v.an_name[v.choices[v.answer]];
        }
        #region 旧コード
        /*
        switch (v.choices[v.answer])
        {
            case 0:
                img.sprite = Resources.Load<Sprite>("images/animal/tora"); name.GetComponent<Text>().text = "トラ";
                break;
            case 1:
                img.sprite = Resources.Load<Sprite>("images/animal/raionn"); name.GetComponent<Text>().text = "ライオン";
                break;
            case 2:
                img.sprite = Resources.Load<Sprite>("images/animal/ti-ta-"); name.GetComponent<Text>().text = "チーター";
                break;
            case 3:
                img.sprite = Resources.Load<Sprite>("images/animal/usi"); name.GetComponent<Text>().text = "牛";
                break;
            case 4:
                img.sprite = Resources.Load<Sprite>("images/animal/niwatori"); name.GetComponent<Text>().text = "にわとり";
                break;
            case 5:
                img.sprite = Resources.Load<Sprite>("images/animal/buta"); name.GetComponent<Text>().text = "豚";
                break;
            case 6:
                img.sprite = Resources.Load<Sprite>("images/animal/kitune"); name.GetComponent<Text>().text = "きつね";
                break;
            case 7:
                img.sprite = Resources.Load<Sprite>("images/animal/tanuki"); name.GetComponent<Text>().text = "たぬき";
                break;
            case 8:
                img.sprite = Resources.Load<Sprite>("images/animal/nezumi"); name.GetComponent<Text>().text = "ネズミ";
                break;

            case 9:
                img.sprite = Resources.Load<Sprite>("images/animal/elephant"); name.GetComponent<Text>().text = "ゾウ";
                break;
            case 10:
                img.sprite = Resources.Load<Sprite>("images/animal/giraffe"); name.GetComponent<Text>().text = "キリン";
                break;
            case 11:
                img.sprite = Resources.Load<Sprite>("images/animal/horse"); name.GetComponent<Text>().text = "ウマ";
                break;
            case 12:
                img.sprite = Resources.Load<Sprite>("images/animal/deer"); name.GetComponent<Text>().text = "シカ";
                break;
            case 13:
                img.sprite = Resources.Load<Sprite>("images/animal/reindeer"); name.GetComponent<Text>().text = "トナカイ";
                break;
            case 14:
                img.sprite = Resources.Load<Sprite>("images/animal/dolphin"); name.GetComponent<Text>().text = "イルカ";
                break;
            case 15:
                img.sprite = Resources.Load<Sprite>("images/animal/whale"); name.GetComponent<Text>().text = "クジラ";
                break;
            case 16:
                img.sprite = Resources.Load<Sprite>("images/animal/bear"); name.GetComponent<Text>().text = "クマ";
                break;
            case 17:
                img.sprite = Resources.Load<Sprite>("images/animal/panda"); name.GetComponent<Text>().text = "パンダ";
                break;
            case 18:
                img.sprite = Resources.Load<Sprite>("images/animal/gorilla"); name.GetComponent<Text>().text = "ゴリラ";
                break;
            case 19:
                img.sprite = Resources.Load<Sprite>("images/animal/hippopotamus"); name.GetComponent<Text>().text = "カバ";
                break;
            case 20:
                img.sprite = Resources.Load<Sprite>("images/animal/goat"); name.GetComponent<Text>().text = "ヤギ";
                break;
            case 21:
                img.sprite = Resources.Load<Sprite>("images/animal/orca"); name.GetComponent<Text>().text = "シャチ";
                break;
            default:
                break;
        }
        */
        #endregion
    }

    private void sp_image_switch()
    {
        for (int i = 0; i < 22; i++)
        {
            img.sprite = Resources.Load<Sprite>(v.sp_pass[v.choices[v.answer]]); name.GetComponent<Text>().text = v.sp_name[v.choices[v.answer]];
        }
        #region 旧コード
        /*
        switch (v.choices[v.answer])
        {
            case 0:
                img.sprite = Resources.Load<Sprite>("images/sports/yakyuu"); name.GetComponent<Text>().text = "野球";
                break;
            case 1:
                img.sprite = Resources.Load<Sprite>("images/sports/sakka-"); name.GetComponent<Text>().text = "サッカー";
                break;
            case 2:
                img.sprite = Resources.Load<Sprite>("images/sports/kenndou"); name.GetComponent<Text>().text = "剣道";
                break;
            case 3:
                img.sprite = Resources.Load<Sprite>("images/sports/bare-"); name.GetComponent<Text>().text = "バレー";
                break;
            case 4:
                img.sprite = Resources.Load<Sprite>("images/sports/basuke"); name.GetComponent<Text>().text = "バスケ";
                break;
            case 5:
                img.sprite = Resources.Load<Sprite>("images/sports/ragubi-"); name.GetComponent<Text>().text = "ラグビー";
                break;
            case 6:
                img.sprite = Resources.Load<Sprite>("images/sports/takkyuu"); name.GetComponent<Text>().text = "卓球";
                break;
            case 7:
                img.sprite = Resources.Load<Sprite>("images/sports/tenisu"); name.GetComponent<Text>().text = "テニス";
                break;
            case 8:
                img.sprite = Resources.Load<Sprite>("images/sports/batominntonn"); name.GetComponent<Text>().text = "バドミントン";
                break;

            case 9:
                img.sprite = Resources.Load<Sprite>("images/sports/golf"); name.GetComponent<Text>().text = "ゴルフ";
                break;
            case 10:
                img.sprite = Resources.Load<Sprite>("images/sports/billiards"); name.GetComponent<Text>().text = "ビリヤード";
                break;
            case 11:
                img.sprite = Resources.Load<Sprite>("images/sports/archery"); name.GetComponent<Text>().text = "アーチェリー";
                break;
            case 12:
                img.sprite = Resources.Load<Sprite>("images/sports/sumou"); name.GetComponent<Text>().text = "相撲";
                break;
            case 13:
                img.sprite = Resources.Load<Sprite>("images/sports/jyuudou"); name.GetComponent<Text>().text = "柔道";
                break;
            case 14:
                img.sprite = Resources.Load<Sprite>("images/sports/handball"); name.GetComponent<Text>().text = "ハンドボール";
                break;
            case 15:
                img.sprite = Resources.Load<Sprite>("images/sports/relay"); name.GetComponent<Text>().text = "リレー";
                break;
            case 16:
                img.sprite = Resources.Load<Sprite>("images/sports/boutakatobi"); name.GetComponent<Text>().text = "棒高跳び";
                break;
            case 17:
                img.sprite = Resources.Load<Sprite>("images/sports/swimming"); name.GetComponent<Text>().text = "水泳";
                break;
            case 18:
                img.sprite = Resources.Load<Sprite>("images/sports/hougannnage"); name.GetComponent<Text>().text = "砲丸投げ";
                break;
            case 19:
                img.sprite = Resources.Load<Sprite>("images/sports/hannma-nage"); name.GetComponent<Text>().text = "ハンマー投げ";
                break;
            case 20:
                img.sprite = Resources.Load<Sprite>("images/sports/gateball"); name.GetComponent<Text>().text = "ゲートボール";
                break;
            case 21:
                img.sprite = Resources.Load<Sprite>("images/sports/boxing"); name.GetComponent<Text>().text = "ボクシング";
                break;

            default:
                break;
        }
        */
        #endregion

    }

    [PunRPC]
    void to_test_frag()
    {
        v.ttf = true;
    }
}
