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

    }

    private void an_image_switch()
    {
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
            default:
                break;
        }

    }

    private void sp_image_switch()
    {
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
            default:
                break;
        }

    }

    [PunRPC]
    void to_test_frag()
    {
        v.ttf = true;
    }
}
