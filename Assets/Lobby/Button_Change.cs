using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Change : MonoBehaviour
{
    [SerializeField]
    private GameObject RoomCreateButton;
    [SerializeField]
    private GameObject BackButton;

    private int check = 1;
    public void change()
    {
        check = check * (-1);
        if (check >= 0)
        {
            RoomCreateButton.SetActive(true);
            BackButton.SetActive(false);

        }
        else
        {
            RoomCreateButton.SetActive(false);
            BackButton.SetActive(true);
        }
    }
}
