using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;//UIであるImageを使用するので追加する
using UnityEngine.SceneManagement;

public class respondent : MonoBehaviourPunCallbacks
{
    //public PhotonView photonView;//pun使うために必用な奴

    public Image img0;//左の画像
    public Image img1;//真ん中の画像
    public Image img2;//右の画像

    public Sprite def;//何もはまらなかった時の画像

    //偉人
    public Sprite greatman0;
    public Sprite greatman1;
    public Sprite greatman2;

    //共有変数
    //private string theme;
    //private int choices = 0;
    //private bool ttf=false;


    private void Start()
    {

        //v.theme = "greatman";
    }

    // Update is called once per frame
    private void Update()
    {
        if (v.theme == "vegetable") ve_image_switch();
        if (v.theme == "animal") an_image_switch();
        if (v.theme == "sports") sp_image_switch();

        if (v.ansum >= v.player_count) photonView.RPC(nameof(to_test_frag), RpcTarget.All);
        //現状Answerシーンに飛ぶ必要がないのでコメントアウトしています 岩下
        //if (v.ttf == true) SceneManager.LoadScene("Answer");
        //photonView.RPC(nameof(SendChatMessage), RpcTarget.Others, "よろしくお願いします");
    }

    private void ve_image_switch()
    {
        for (int i = 0; i < 22; i++)
        {
            img0.sprite = Resources.Load<Sprite>(v.ve_pass[v.choices[0]]);
            img1.sprite = Resources.Load<Sprite>(v.ve_pass[v.choices[1]]);
            img2.sprite = Resources.Load<Sprite>(v.ve_pass[v.choices[2]]);
        }
        #region 旧コード
        /*
        switch (v.choices[0])
        {
            case 0:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/burokkori-");
                break;
            case 1:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/pi-mnn");
                break;
            case 2:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/kyu-ri");
                break;
            case 3:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/kyabetu");
                break;
            case 4:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/retasu");
                break;
            case 5:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/hakusai");
                break;
            case 6:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/tomato");
                break;
            case 7:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/jagaimo");
                break;
            case 8:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/papurika");
                break;
            case 9:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/komatuna");
                break;
            case 10:
                img0.sprite = Resources.Load<Sprite>("images/vegetable/serori-");
                break;
            default:
                break;
        }
        switch (v.choices[1])
        {
            case 0:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/burokkori-");
                break;
            case 1:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/pi-mnn");
                break;
            case 2:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/kyu-ri");
                break;
            case 3:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/kyabetu");
                break;
            case 4:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/retasu");
                break;
            case 5:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/hakusai");
                break;
            case 6:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/tomato");
                break;
            case 7:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/jagaimo");
                break;
            case 8:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/papurika");
                break;
            case 9:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/komatuna");
                break;
            case 10:
                img1.sprite = Resources.Load<Sprite>("images/vegetable/serori-");
                break;
            default:
                break;
        }
        switch (v.choices[2])
        {
            case 0:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/burokkori-");
                break;
            case 1:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/pi-mnn");
                break;
            case 2:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/kyu-ri");
                break;
            case 3:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/kyabetu");
                break;
            case 4:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/retasu");
                break;
            case 5:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/hakusai");
                break;
            case 6:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/tomato");
                break;
            case 7:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/jagaimo");
                break;
            case 8:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/papurika");
                break;
            case 9:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/komatuna");
                break;
            case 10:
                img2.sprite = Resources.Load<Sprite>("images/vegetable/serori-");
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
            img0.sprite = Resources.Load<Sprite>(v.an_pass[v.choices[0]]);
            img1.sprite = Resources.Load<Sprite>(v.an_pass[v.choices[1]]);
            img2.sprite = Resources.Load<Sprite>(v.an_pass[v.choices[2]]);
        }
        #region 旧コード
        /*
        switch (v.choices[0])
        {
            case 0:
                img0.sprite = Resources.Load<Sprite>("images/animal/tora");
                break;
            case 1:
                img0.sprite = Resources.Load<Sprite>("images/animal/raionn");
                break;
            case 2:
                img0.sprite = Resources.Load<Sprite>("images/animal/ti-ta-");
                break;
            case 3:
                img0.sprite = Resources.Load<Sprite>("images/animal/usi");
                break;
            case 4:
                img0.sprite = Resources.Load<Sprite>("images/animal/niwatori");
                break;
            case 5:
                img0.sprite = Resources.Load<Sprite>("images/animal/buta");
                break;
            case 6:
                img0.sprite = Resources.Load<Sprite>("images/animal/kitune");
                break;
            case 7:
                img0.sprite = Resources.Load<Sprite>("images/animal/tanuki");
                break;
            case 8:
                img0.sprite = Resources.Load<Sprite>("images/animal/nezumi");
                break;
            default:
                break;
        }
        switch (v.choices[1])
        {
            case 0:
                img1.sprite = Resources.Load<Sprite>("images/animal/tora");
                break;
            case 1:
                img1.sprite = Resources.Load<Sprite>("images/animal/raionn");
                break;
            case 2:
                img1.sprite = Resources.Load<Sprite>("images/animal/ti-ta-");
                break;
            case 3:
                img1.sprite = Resources.Load<Sprite>("images/animal/usi");
                break;
            case 4:
                img1.sprite = Resources.Load<Sprite>("images/animal/niwatori");
                break;
            case 5:
                img1.sprite = Resources.Load<Sprite>("images/animal/buta");
                break;
            case 6:
                img1.sprite = Resources.Load<Sprite>("images/animal/kitune");
                break;
            case 7:
                img1.sprite = Resources.Load<Sprite>("images/animal/tanuki");
                break;
            case 8:
                img1.sprite = Resources.Load<Sprite>("images/animal/nezumi");
                break;
            default:
                break;
        }
        switch (v.choices[2])
        {
            case 0:
                img2.sprite = Resources.Load<Sprite>("images/animal/tora");
                break;
            case 1:
                img2.sprite = Resources.Load<Sprite>("images/animal/raionn");
                break;
            case 2:
                img2.sprite = Resources.Load<Sprite>("images/animal/ti-ta-");
                break;
            case 3:
                img2.sprite = Resources.Load<Sprite>("images/animal/usi");
                break;
            case 4:
                img2.sprite = Resources.Load<Sprite>("images/animal/niwatori");
                break;
            case 5:
                img2.sprite = Resources.Load<Sprite>("images/animal/buta");
                break;
            case 6:
                img2.sprite = Resources.Load<Sprite>("images/animal/kitune");
                break;
            case 7:
                img2.sprite = Resources.Load<Sprite>("images/animal/tanuki");
                break;
            case 8:
                img2.sprite = Resources.Load<Sprite>("images/animal/nezumi");
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
            img0.sprite = Resources.Load<Sprite>(v.sp_pass[v.choices[0]]);
            img1.sprite = Resources.Load<Sprite>(v.sp_pass[v.choices[1]]);
            img2.sprite = Resources.Load<Sprite>(v.sp_pass[v.choices[2]]);
        }
        #region 旧コード
        /*
        switch (v.choices[0])
        {
            case 0:
                img0.sprite = Resources.Load<Sprite>("images/sports/yakyuu");
                break;
            case 1:
                img0.sprite = Resources.Load<Sprite>("images/sports/sakka-");
                break;
            case 2:
                img0.sprite = Resources.Load<Sprite>("images/sports/kenndou");
                break;
            case 3:
                img0.sprite = Resources.Load<Sprite>("images/sports/bare-");
                break;
            case 4:
                img0.sprite = Resources.Load<Sprite>("images/sports/basuke");
                break;
            case 5:
                img0.sprite = Resources.Load<Sprite>("images/sports/ragubi-");
                break;
            case 6:
                img0.sprite = Resources.Load<Sprite>("images/sports/takkyuu");
                break;
            case 7:
                img0.sprite = Resources.Load<Sprite>("images/sports/tenisu");
                break;
            case 8:
                img0.sprite = Resources.Load<Sprite>("images/sports/batominntonn");
                break;
            default:
                break;
        }
        switch (v.choices[1])
        {
            case 0:
                img1.sprite = Resources.Load<Sprite>("images/sports/yakyuu");
                break;
            case 1:
                img1.sprite = Resources.Load<Sprite>("images/sports/sakka-");
                break;
            case 2:
                img1.sprite = Resources.Load<Sprite>("images/sports/kenndou");
                break;
            case 3:
                img1.sprite = Resources.Load<Sprite>("images/sports/bare-");
                break;
            case 4:
                img1.sprite = Resources.Load<Sprite>("images/sports/basuke");
                break;
            case 5:
                img1.sprite = Resources.Load<Sprite>("images/sports/ragubi-");
                break;
            case 6:
                img1.sprite = Resources.Load<Sprite>("images/sports/takkyuu");
                break;
            case 7:
                img1.sprite = Resources.Load<Sprite>("images/sports/tenisu");
                break;
            case 8:
                img1.sprite = Resources.Load<Sprite>("images/sports/batominntonn");
                break;
            default:
                break;
        }
        switch (v.choices[2])
        {
            case 0:
                img2.sprite = Resources.Load<Sprite>("images/sports/yakyuu");
                break;
            case 1:
                img2.sprite = Resources.Load<Sprite>("images/sports/sakka-");
                break;
            case 2:
                img2.sprite = Resources.Load<Sprite>("images/sports/kenndou");
                break;
            case 3:
                img2.sprite = Resources.Load<Sprite>("images/sports/bare-");
                break;
            case 4:
                img2.sprite = Resources.Load<Sprite>("images/sports/basuke");
                break;
            case 5:
                img2.sprite = Resources.Load<Sprite>("images/sports/ragubi-");
                break;
            case 6:
                img2.sprite = Resources.Load<Sprite>("images/sports/takkyuu");
                break;
            case 7:
                img2.sprite = Resources.Load<Sprite>("images/sports/tenisu");
                break;
            case 8:
                img2.sprite = Resources.Load<Sprite>("images/sports/batominntonn");
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

    [PunRPC]
    private void SendChatMessage(string message)
    {
        Debug.Log(message);
    }
}
