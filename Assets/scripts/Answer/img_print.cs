using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class img_print : MonoBehaviourPunCallbacks
{
    public PhotonView photonView;//pun使うために必用な奴

    public Image img;//画像

    //偉人
    public Sprite greatman0;
    public Sprite greatman1;
    public Sprite greatman2;

    //private string theme;
    //private int choices = 0;
    //private int answer=0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("v.answer" + v.answer);
        //theme = "greatman";
    }

    // Update is called once per frame
    void Update()
    {
        if (v.theme == "vegetable") ve_image_switch();
        if (v.theme == "animal") an_image_switch();
        //if (v.tohome == true) SceneManager.LoadScene("home");
    }

    private void ve_image_switch()
    {
        switch (v.choices[v.answer])
        {
            case 0:
                img.sprite = Resources.Load<Sprite>("images/vegetable/burokkori-");
                break;
            case 1:
                img.sprite = Resources.Load<Sprite>("images/vegetable/pi-mnn");
                break;
            case 2:
                img.sprite = Resources.Load<Sprite>("images/vegetable/kyu-ri");
                break;
            case 3:
                img.sprite = Resources.Load<Sprite>("images/vegetable/kyabetu");
                break;
            case 4:
                img.sprite = Resources.Load<Sprite>("images/vegetable/retasu");
                break;
            case 5:
                img.sprite = Resources.Load<Sprite>("images/vegetable/hakusai");
                break;
            case 6:
                img.sprite = Resources.Load<Sprite>("images/vegetable/tomato");
                break;
            case 7:
                img.sprite = Resources.Load<Sprite>("images/vegetable/jagaimo");
                break;
            case 8:
                img.sprite = Resources.Load<Sprite>("images/vegetable/papurika");
                break;
            case 9:
                img.sprite = Resources.Load<Sprite>("images/vegetable/komatuna");
                break;
            case 10:
                img.sprite = Resources.Load<Sprite>("images/vegetable/serori-");
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
                img.sprite = Resources.Load<Sprite>("images/animal/tora");
                break;
            case 1:
                img.sprite = Resources.Load<Sprite>("images/animal/raionn");
                break;
            case 2:
                img.sprite = Resources.Load<Sprite>("images/animal/ti-ta-");
                break;
            case 3:
                img.sprite = Resources.Load<Sprite>("images/animal/usi");
                break;
            case 4:
                img.sprite = Resources.Load<Sprite>("images/animal/niwatori");
                break;
            case 5:
                img.sprite = Resources.Load<Sprite>("images/animal/buta");
                break;
            case 6:
                img.sprite = Resources.Load<Sprite>("images/animal/kitune");
                break;
            case 7:
                img.sprite = Resources.Load<Sprite>("images/animal/tanuki");
                break;
            case 8:
                img.sprite = Resources.Load<Sprite>("images/animal/nezumi");
                break;
            default:
                break;
        }

    }


}
