﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("level2");
    }
}
