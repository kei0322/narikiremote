using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll_img : MonoBehaviour
{
    int count = 3;

    public float speed = 1.0f;
    public Sprite first;
    public Sprite second;
    public Sprite third;
    public Sprite forth;

    public Image Image0;
    public Image Image1;
    public Image Image2;


    Sprite[] Img_roop;
    Image[] slide;

    [SerializeField]
    Animator ButtonTrigger = null;



    // Start is called before the first frame update
    void Start()
    {
        var parent = this.transform;
        Img_roop = new Sprite[] { first, second, third, forth };
        slide = new Image[] { Image0, Image1, Image2 };
        slide_show();
    }

    public void slide_show()
    {
        for (int i = 0; i < 3; i++)
        {
            slide[i].sprite = Img_roop[(count + i) % 4];
            //var setup = Instantiate(Image_roop[(count + i) % 4], new Vector3(-200 + (200 * i), 0, 0), Quaternion.identity);

        }
    }

    public void R_onClick()
    {
        count += 1;
        //Invoke("slide_show", speed);
        ButtonTrigger.SetTrigger("R_Button");

    }
    public void L_onClick()
    {
        count += 3;
        //Invoke("slide_show", speed);
        ButtonTrigger.SetTrigger("L_Button");
    }

}
