using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer_print : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (v.theme == "vegetable") ve_text_switch();
        if (v.theme == "animal") an_text_switch();
        if (v.theme == "sports") sp_text_switch();
    }

    private void ve_text_switch()
    {
        for (int i = 0; i < 22; i++)
        {
            this.GetComponent<Text>().text = v.ve_name[v.choices[v.answer]];
        }
        #region 旧コード
        /*
        switch (v.choices[v.answer])
        {
            case 0:
                this.GetComponent<Text>().text = "ブロッコリー";
                break;
            case 1:
                this.GetComponent<Text>().text = "ピーマン";
                break;
            case 2:
                this.GetComponent<Text>().text = "きゅうり";
                break;
            case 3:
                this.GetComponent<Text>().text = "キャベツ";
                break;
            case 4:
                this.GetComponent<Text>().text = "レタス";
                break;
            case 5:
                this.GetComponent<Text>().text = "白菜";
                break;
            case 6:
                this.GetComponent<Text>().text = "トマト";
                break;
            case 7:
                this.GetComponent<Text>().text = "じゃがいも";
                break;
            case 8:
                this.GetComponent<Text>().text = "パプリカ";
                break;
            case 9:
                this.GetComponent<Text>().text = "小松菜";
                break;
            case 10:
                this.GetComponent<Text>().text = "セロリ";
                break;

            case 11:
                this.GetComponent<Text>().text = "ウマ";
                break;
            case 12:
                this.GetComponent<Text>().text = "シカ";
                break;
            case 13:
                this.GetComponent<Text>().text = "トナカイ";
                break;
            case 14:
                this.GetComponent<Text>().text = "イルカ";
                break;
            case 15:
                this.GetComponent<Text>().text = "クジラ";
                break;
            case 16:
                this.GetComponent<Text>().text = "クマ";
                break;
            case 17:
                this.GetComponent<Text>().text = "パンダ";
                break;
            case 18:
                this.GetComponent<Text>().text = "ゴリラ";
                break;
            case 19:
                this.GetComponent<Text>().text = "カバ";
                break;
            case 20:
                this.GetComponent<Text>().text = "ヤギ";
                break;
            case 21:
                this.GetComponent<Text>().text = "シャチ";
                break;
            default:
                break;
        }
        */
        #endregion
    }

    private void an_text_switch()
    {
        for (int i=0; i<22; i++)
        {
            this.GetComponent<Text>().text = v.an_name[v.choices[v.answer]];
        }
        #region 旧コード
        /*
        switch (v.choices[v.answer])
        {
            case 0:
                this.GetComponent<Text>().text = "トラ";
                break;
            case 1:
                this.GetComponent<Text>().text = "ライオン";
                break;
            case 2:
                this.GetComponent<Text>().text = "チーター";
                break;
            case 3:
                this.GetComponent<Text>().text = "牛";
                break;
            case 4:
                this.GetComponent<Text>().text = "にわとり";
                break;
            case 5:
                this.GetComponent<Text>().text = "豚";
                break;
            case 6:
                this.GetComponent<Text>().text = "きつね";
                break;
            case 7:
                this.GetComponent<Text>().text = "たぬき";
                break;
            case 8:
                this.GetComponent<Text>().text = "ネズミ";
                break;

            case 9:
                this.GetComponent<Text>().text = "ゾウ";
                break;
            case 10:
                this.GetComponent<Text>().text = "キリン";
                break;
            case 11:
                this.GetComponent<Text>().text = "ウマ";
                break;
            case 12:
                this.GetComponent<Text>().text = "シカ";
                break;
            case 13:
                this.GetComponent<Text>().text = "トナカイ";
                break;
            case 14:
                this.GetComponent<Text>().text = "イルカ";
                break;
            case 15:
                this.GetComponent<Text>().text = "クジラ";
                break;
            case 16:
                this.GetComponent<Text>().text = "クマ";
                break;
            case 17:
                this.GetComponent<Text>().text = "パンダ";
                break;
            case 18:
                this.GetComponent<Text>().text = "ゴリラ";
                break;
            case 19:
                this.GetComponent<Text>().text = "カバ";
                break;
            case 20:
                this.GetComponent<Text>().text = "ヤギ";
                break;
            case 21:
                this.GetComponent<Text>().text = "シャチ";
                break;
            default:
                break;
        }
        */
        #endregion
    }

    private void sp_text_switch()
    {
        for (int i = 0; i < 22; i++)
        {
            this.GetComponent<Text>().text = v.sp_name[v.choices[v.answer]];
        }
        #region 旧コード
        /*
        switch (v.choices[v.answer])
        {
            case 0:
                this.GetComponent<Text>().text = "野球";
                break;
            case 1:
                this.GetComponent<Text>().text = "サッカー";
                break;
            case 2:
                this.GetComponent<Text>().text = "剣道";
                break;
            case 3:
                this.GetComponent<Text>().text = "バレー";
                break;
            case 4:
                this.GetComponent<Text>().text = "バスケ";
                break;
            case 5:
                this.GetComponent<Text>().text = "ラグビー";
                break;
            case 6:
                this.GetComponent<Text>().text = "卓球";
                break;
            case 7:
                this.GetComponent<Text>().text = "テニス";
                break;
            case 8:
                this.GetComponent<Text>().text = "バドミントン";
                break;

            case 9:
                this.GetComponent<Text>().text = "ゴルフ";
                break;
            case 10:
                this.GetComponent<Text>().text = "ビリヤード";
                break;
            case 11:
                this.GetComponent<Text>().text = "アーチェリー";
                break;
            case 12:
                this.GetComponent<Text>().text = "相撲";
                break;
            case 13:
                this.GetComponent<Text>().text = "柔道";
                break;
            case 14:
                this.GetComponent<Text>().text = "ハンドボール";
                break;
            case 15:
                this.GetComponent<Text>().text = "リレー";
                break;
            case 16:
                this.GetComponent<Text>().text = "棒高跳び";
                break;
            case 17:
                this.GetComponent<Text>().text = "水泳";
                break;
            case 18:
                this.GetComponent<Text>().text = "砲丸投げ";
                break;
            case 19:
                this.GetComponent<Text>().text = "ハンマー投げ";
                break;
            case 20:
                this.GetComponent<Text>().text = "ゲートボール";
                break;
            case 21:
                this.GetComponent<Text>().text = "ボクシング";
                break;
            default:
                break;
        }
        */
        #endregion
    }
}
