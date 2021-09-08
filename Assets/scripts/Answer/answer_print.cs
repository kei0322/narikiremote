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
    }

    private void ve_text_switch()
    {
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
            default:
                break;
        }

    }

    private void an_text_switch()
    {
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
            default:
                break;
        }
    }
}
