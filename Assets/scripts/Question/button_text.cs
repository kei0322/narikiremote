using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_text : MonoBehaviour
{
    public GameObject bt0;
    public GameObject bt1;
    public GameObject bt2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (v.theme == "vegetable") ve_image_switch();
        if (v.theme == "animal") an_image_switch();
        if (v.theme == "sports") sp_image_switch();
    }

    private void ve_image_switch()
    {
        for (int i = 0; i < 22; i++)
        {
            bt0.GetComponent<Text>().text = v.ve_name[v.choices[0]];
            bt1.GetComponent<Text>().text = v.ve_name[v.choices[1]];
            bt2.GetComponent<Text>().text = v.ve_name[v.choices[2]];
        }
        #region 旧コード
        /*
        switch (v.choices[0])
        {
            case 0:
                bt0.GetComponent<Text>().text = "ブロッコリー";
                break;
            case 1:
                bt0.GetComponent<Text>().text = "ピーマン";
                break;
            case 2:
                bt0.GetComponent<Text>().text = "きゅうり";
                break;
            case 3:
                bt0.GetComponent<Text>().text = "きゃべつ";
                break;
            case 4:
                bt0.GetComponent<Text>().text = "レタス";
                break;
            case 5:
                bt0.GetComponent<Text>().text = "白菜";
                break;
            case 6:
                bt0.GetComponent<Text>().text = "トマト";
                break;
            case 7:
                bt0.GetComponent<Text>().text = "じゃがいも";
                break;
            case 8:
                bt0.GetComponent<Text>().text = "パプリカ";
                break;
            case 9:
                bt0.GetComponent<Text>().text = "小松菜";
                break;
            case 10:
                bt0.GetComponent<Text>().text = "セロリ";
                break;

            case 11:
                bt0.GetComponent<Text>().text = "ウマ";
                break;
            case 12:
                bt0.GetComponent<Text>().text = "シカ";
                break;
            case 13:
                bt0.GetComponent<Text>().text = "トナカイ";
                break;
            case 14:
                bt0.GetComponent<Text>().text = "イルカ";
                break;
            case 15:
                bt0.GetComponent<Text>().text = "クジラ";
                break;
            case 16:
                bt0.GetComponent<Text>().text = "クマ";
                break;
            case 17:
                bt0.GetComponent<Text>().text = "パンダ";
                break;
            case 18:
                bt0.GetComponent<Text>().text = "ゴリラ";
                break;
            case 19:
                bt0.GetComponent<Text>().text = "カバ";
                break;
            case 20:
                bt0.GetComponent<Text>().text = "ヤギ";
                break;
            case 21:
                bt0.GetComponent<Text>().text = "シャチ";
                break;

            default:
                break;

        }

        switch (v.choices[1])
        {
            case 0:
                bt1.GetComponent<Text>().text = "ブロッコリー";
                break;
            case 1:
                bt1.GetComponent<Text>().text = "ピーマン";
                break;
            case 2:
                bt1.GetComponent<Text>().text = "きゅうり";
                break;
            case 3:
                bt1.GetComponent<Text>().text = "キャベツ";
                break;
            case 4:
                bt1.GetComponent<Text>().text = "レタス";
                break;
            case 5:
                bt1.GetComponent<Text>().text = "白菜";
                break;
            case 6:
                bt1.GetComponent<Text>().text = "トマト";
                break;
            case 7:
                bt1.GetComponent<Text>().text = "じゃがいも";
                break;
            case 8:
                bt1.GetComponent<Text>().text = "パプリカ";
                break;
            case 9:
                bt1.GetComponent<Text>().text = "小松菜";
                break;
            case 10:
                bt1.GetComponent<Text>().text = "セロリ";
                break;

            default:
                break;

        }

        switch (v.choices[2])
        {
            case 0:
                bt2.GetComponent<Text>().text = "ブロッコリー";
                break;
            case 1:
                bt2.GetComponent<Text>().text = "ピーマン";
                break;
            case 2:
                bt2.GetComponent<Text>().text = "きゅうり";
                break;
            case 3:
                bt2.GetComponent<Text>().text = "キャベツ";
                break;
            case 4:
                bt2.GetComponent<Text>().text = "レタス";
                break;
            case 5:
                bt2.GetComponent<Text>().text = "白菜";
                break;
            case 6:
                bt2.GetComponent<Text>().text = "トマト";
                break;
            case 7:
                bt2.GetComponent<Text>().text = "じゃがいも";
                break;
            case 8:
                bt2.GetComponent<Text>().text = "パプリカ";
                break;
            case 9:
                bt2.GetComponent<Text>().text = "小松菜";
                break;
            case 10:
                bt2.GetComponent<Text>().text = "セロリ";
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
            bt0.GetComponent<Text>().text = v.an_name[v.choices[0]];
            bt1.GetComponent<Text>().text = v.an_name[v.choices[1]];
            bt2.GetComponent<Text>().text = v.an_name[v.choices[2]];
        }
        #region 旧コード
        /*
        switch (v.choices[0])
        {
            case 0:
                bt0.GetComponent<Text>().text = "トラ";
                break;
            case 1:
                bt0.GetComponent<Text>().text = "ライオン";
                break;
            case 2:
                bt0.GetComponent<Text>().text = "チーター";
                break;
            case 3:
                bt0.GetComponent<Text>().text = "牛";
                break;
            case 4:
                bt0.GetComponent<Text>().text = "にわとり";
                break;
            case 5:
                bt0.GetComponent<Text>().text = "豚";
                break;
            case 6:
                bt0.GetComponent<Text>().text = "きつね";
                break;
            case 7:
                bt0.GetComponent<Text>().text = "たぬき";
                break;
            case 8:
                bt0.GetComponent<Text>().text = "ネズミ";
                break;

            case 9:
                bt0.GetComponent<Text>().text = "ゾウ";
                break;
            case 10:
                bt0.GetComponent<Text>().text = "キリン";
                break;
            case 11:
                bt0.GetComponent<Text>().text = "ウマ";
                break;
            case 12:
                bt0.GetComponent<Text>().text = "シカ";
                break;
            case 13:
                bt0.GetComponent<Text>().text = "トナカイ";
                break;
            case 14:
                bt0.GetComponent<Text>().text = "イルカ";
                break;
            case 15:
                bt0.GetComponent<Text>().text = "クジラ";
                break;
            case 16:
                bt0.GetComponent<Text>().text = "クマ";
                break;
            case 17:
                bt0.GetComponent<Text>().text = "パンダ";
                break;
            case 18:
                bt0.GetComponent<Text>().text = "ゴリラ";
                break;
            case 19:
                bt0.GetComponent<Text>().text = "カバ";
                break;
            case 20:
                bt0.GetComponent<Text>().text = "ヤギ";
                break;
            case 21:
                bt0.GetComponent<Text>().text = "シャチ";
                break;

            default:
                break;

        }

        switch (v.choices[1])
        {
            case 0:
                bt1.GetComponent<Text>().text = "トラ";
                break;
            case 1:
                bt1.GetComponent<Text>().text = "ライオン";
                break;
            case 2:
                bt1.GetComponent<Text>().text = "チーター";
                break;
            case 3:
                bt1.GetComponent<Text>().text = "牛";
                break;
            case 4:
                bt1.GetComponent<Text>().text = "にわとり";
                break;
            case 5:
                bt1.GetComponent<Text>().text = "豚";
                break;
            case 6:
                bt1.GetComponent<Text>().text = "きつね";
                break;
            case 7:
                bt1.GetComponent<Text>().text = "たぬき";
                break;
            case 8:
                bt1.GetComponent<Text>().text = "ネズミ";
                break;

            case 9:
                bt1.GetComponent<Text>().text = "ゾウ";
                break;
            case 10:
                bt1.GetComponent<Text>().text = "キリン";
                break;
            case 11:
                bt1.GetComponent<Text>().text = "ウマ";
                break;
            case 12:
                bt1.GetComponent<Text>().text = "シカ";
                break;
            case 13:
                bt1.GetComponent<Text>().text = "トナカイ";
                break;
            case 14:
                bt1.GetComponent<Text>().text = "イルカ";
                break;
            case 15:
                bt1.GetComponent<Text>().text = "クジラ";
                break;
            case 16:
                bt1.GetComponent<Text>().text = "クマ";
                break;
            case 17:
                bt1.GetComponent<Text>().text = "パンダ";
                break;
            case 18:
                bt1.GetComponent<Text>().text = "ゴリラ";
                break;
            case 19:
                bt1.GetComponent<Text>().text = "カバ";
                break;
            case 20:
                bt1.GetComponent<Text>().text = "ヤギ";
                break;
            case 21:
                bt1.GetComponent<Text>().text = "シャチ";
                break;

            default:
                break;

        }

        switch (v.choices[2])
        {
            case 0:
                bt2.GetComponent<Text>().text = "トラ";
                break;
            case 1:
                bt2.GetComponent<Text>().text = "ライオン";
                break;
            case 2:
                bt2.GetComponent<Text>().text = "チーター";
                break;
            case 3:
                bt2.GetComponent<Text>().text = "牛";
                break;
            case 4:
                bt2.GetComponent<Text>().text = "にわとり";
                break;
            case 5:
                bt2.GetComponent<Text>().text = "豚";
                break;
            case 6:
                bt2.GetComponent<Text>().text = "きつね";
                break;
            case 7:
                bt2.GetComponent<Text>().text = "たぬき";
                break;
            case 8:
                bt2.GetComponent<Text>().text = "ネズミ";
                break;

            case 9:
                bt2.GetComponent<Text>().text = "ゾウ";
                break;
            case 10:
                bt2.GetComponent<Text>().text = "キリン";
                break;
            case 11:
                bt2.GetComponent<Text>().text = "ウマ";
                break;
            case 12:
                bt2.GetComponent<Text>().text = "シカ";
                break;
            case 13:
                bt2.GetComponent<Text>().text = "トナカイ";
                break;
            case 14:
                bt2.GetComponent<Text>().text = "イルカ";
                break;
            case 15:
                bt2.GetComponent<Text>().text = "クジラ";
                break;
            case 16:
                bt2.GetComponent<Text>().text = "クマ";
                break;
            case 17:
                bt2.GetComponent<Text>().text = "パンダ";
                break;
            case 18:
                bt2.GetComponent<Text>().text = "ゴリラ";
                break;
            case 19:
                bt2.GetComponent<Text>().text = "カバ";
                break;
            case 20:
                bt2.GetComponent<Text>().text = "ヤギ";
                break;
            case 21:
                bt2.GetComponent<Text>().text = "シャチ";
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
            bt0.GetComponent<Text>().text = v.sp_name[v.choices[0]];
            bt1.GetComponent<Text>().text = v.sp_name[v.choices[1]];
            bt2.GetComponent<Text>().text = v.sp_name[v.choices[2]];
        }
        #region 旧コード
        /*
        switch (v.choices[0])
        {
            case 0:
                bt0.GetComponent<Text>().text = "野球";
                break;
            case 1:
                bt0.GetComponent<Text>().text = "サッカー";
                break;
            case 2:
                bt0.GetComponent<Text>().text = "剣道";
                break;
            case 3:
                bt0.GetComponent<Text>().text = "バレー";
                break;
            case 4:
                bt0.GetComponent<Text>().text = "バスケ";
                break;
            case 5:
                bt0.GetComponent<Text>().text = "ラグビー";
                break;
            case 6:
                bt0.GetComponent<Text>().text = "卓球";
                break;
            case 7:
                bt0.GetComponent<Text>().text = "テニス";
                break;
            case 8:
                bt0.GetComponent<Text>().text = "バドミントン";
                break;

            case 9:
                bt0.GetComponent<Text>().text = "ゴルフ";
                break;
            case 10:
                bt0.GetComponent<Text>().text = "ビリヤード";
                break;
            case 11:
                bt0.GetComponent<Text>().text = "アーチェリー";
                break;
            case 12:
                bt0.GetComponent<Text>().text = "相撲";
                break;
            case 13:
                bt0.GetComponent<Text>().text = "柔道";
                break;
            case 14:
                bt0.GetComponent<Text>().text = "ハンドボール";
                break;
            case 15:
                bt0.GetComponent<Text>().text = "リレー";
                break;
            case 16:
                bt0.GetComponent<Text>().text = "棒高跳び";
                break;
            case 17:
                bt0.GetComponent<Text>().text = "水泳";
                break;
            case 18:
                bt0.GetComponent<Text>().text = "砲丸投げ";
                break;
            case 19:
                bt0.GetComponent<Text>().text = "ハンマー投げ";
                break;
            case 20:
                bt0.GetComponent<Text>().text = "ゲートボール";
                break;
            case 21:
                bt0.GetComponent<Text>().text = "ボクシング";
                break;

            default:
                break;

        }

        switch (v.choices[1])
        {

            case 0:
                bt1.GetComponent<Text>().text = "野球";
                break;
            case 1:
                bt1.GetComponent<Text>().text = "サッカー";
                break;
            case 2:
                bt1.GetComponent<Text>().text = "剣道";
                break;
            case 3:
                bt1.GetComponent<Text>().text = "バレー";
                break;
            case 4:
                bt1.GetComponent<Text>().text = "バスケ";
                break;
            case 5:
                bt1.GetComponent<Text>().text = "ラグビー";
                break;
            case 6:
                bt1.GetComponent<Text>().text = "卓球";
                break;
            case 7:
                bt1.GetComponent<Text>().text = "テニス";
                break;
            case 8:
                bt1.GetComponent<Text>().text = "バドミントン";
                break;

            case 9:
                bt1.GetComponent<Text>().text = "ゴルフ";
                break;
            case 10:
                bt1.GetComponent<Text>().text = "ビリヤード";
                break;
            case 11:
                bt1.GetComponent<Text>().text = "アーチェリー";
                break;
            case 12:
                bt1.GetComponent<Text>().text = "相撲";
                break;
            case 13:
                bt1.GetComponent<Text>().text = "柔道";
                break;
            case 14:
                bt1.GetComponent<Text>().text = "ハンドボール";
                break;
            case 15:
                bt1.GetComponent<Text>().text = "リレー";
                break;
            case 16:
                bt1.GetComponent<Text>().text = "棒高跳び";
                break;
            case 17:
                bt1.GetComponent<Text>().text = "水泳";
                break;
            case 18:
                bt1.GetComponent<Text>().text = "砲丸投げ";
                break;
            case 19:
                bt1.GetComponent<Text>().text = "ハンマー投げ";
                break;
            case 20:
                bt1.GetComponent<Text>().text = "ゲートボール";
                break;
            case 21:
                bt1.GetComponent<Text>().text = "ボクシング";
                break;

            default:
                break;
        }

        switch (v.choices[2])
        {

            case 0:
                bt2.GetComponent<Text>().text = "野球";
                break;
            case 1:
                bt2.GetComponent<Text>().text = "サッカー";
                break;
            case 2:
                bt2.GetComponent<Text>().text = "剣道";
                break;
            case 3:
                bt2.GetComponent<Text>().text = "バレー";
                break;
            case 4:
                bt2.GetComponent<Text>().text = "バスケ";
                break;
            case 5:
                bt2.GetComponent<Text>().text = "ラグビー";
                break;
            case 6:
                bt2.GetComponent<Text>().text = "卓球";
                break;
            case 7:
                bt2.GetComponent<Text>().text = "テニス";
                break;
            case 8:
                bt2.GetComponent<Text>().text = "バドミントン";
                break;

            case 9:
                bt2.GetComponent<Text>().text = "ゴルフ";
                break;
            case 10:
                bt2.GetComponent<Text>().text = "ビリヤード";
                break;
            case 11:
                bt2.GetComponent<Text>().text = "アーチェリー";
                break;
            case 12:
                bt2.GetComponent<Text>().text = "相撲";
                break;
            case 13:
                bt2.GetComponent<Text>().text = "柔道";
                break;
            case 14:
                bt2.GetComponent<Text>().text = "ハンドボール";
                break;
            case 15:
                bt2.GetComponent<Text>().text = "リレー";
                break;
            case 16:
                bt2.GetComponent<Text>().text = "棒高跳び";
                break;
            case 17:
                bt2.GetComponent<Text>().text = "水泳";
                break;
            case 18:
                bt2.GetComponent<Text>().text = "砲丸投げ";
                break;
            case 19:
                bt2.GetComponent<Text>().text = "ハンマー投げ";
                break;
            case 20:
                bt2.GetComponent<Text>().text = "ゲートボール";
                break;
            case 21:
                bt2.GetComponent<Text>().text = "ボクシング";
                break;

            default:
                break;
        }
        */
        #endregion
    }
}
