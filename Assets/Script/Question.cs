﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Question : MonoBehaviour
{
    public void LoadingNewScene()
    {
        SceneManager.LoadScene("Questions");
    }
}