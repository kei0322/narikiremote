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
    }

    private void ve_image_switch()
    {
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

    }

    private void an_image_switch()
    {
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

            default:
                break;

        }

    }
}
