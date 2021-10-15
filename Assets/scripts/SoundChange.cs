using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundChange : MonoBehaviour
{
    [SerializeField]
    private GameObject BGM_ON;
    [SerializeField]
    private GameObject BGM_OFF;

    private int check = 1;
    public void change()
    {
        check = check * (-1);
        if (check >= 0)
        {
            BGM_ON.SetActive(true);
            BGM_OFF.SetActive(false);
            v.OnOff = v.OnOff + 1;
        }
        else
        {
            BGM_ON.SetActive(false);
            BGM_OFF.SetActive(true);
            v.OnOff = v.OnOff - 1;
        }
    }
}
