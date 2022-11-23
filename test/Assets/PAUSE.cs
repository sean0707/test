﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAUSE : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isPause;

    void Start()
    {
        isPause = true;
        Time.timeScale = 0;
    }

    void Update()
    {

    }
    public void OnClick()
    {
        isPause = !isPause;
        if (isPause)
        {
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;
        }
        Destroy(gameObject);
    }
}
